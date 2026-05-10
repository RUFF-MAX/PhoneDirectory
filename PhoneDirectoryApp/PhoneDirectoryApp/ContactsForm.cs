using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhoneDirectoryApp
{
    /// <summary>
    /// Форма для отображения, навигации и управления контактами.
    /// </summary>
    public partial class ContactsForm : Form
    {
        /// <summary>
        /// Адаптер для выполнения SQL-запроса и заполнения таблицы данных.
        /// </summary>
        private SqlDataAdapter _adapter;

        /// <summary>
        /// Локальное хранилище данных, полученных из базы.
        /// </summary>
        private DataTable _dataTable;

        /// <summary>
        /// Посредник между данными и элементами интерфейса.
        /// </summary>
        private BindingSource _bindingSource;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public ContactsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие загрузки формы.
        /// </summary>
        private void ContactsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxes();
        }

        /// <summary>
        /// Загружает контакты из базы данных и связывает их с элементами интерфейса.
        /// </summary>
        private void LoadData()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetInstance().GetConnection();

                string query = @"SELECT 
                k.Id_Контакта,
                k.Имя,
                k.Фамилия,
                k.Дата_Добавления,
                k.Фото_Контакта,
                RTRIM(ISNULL(a.Страна, '')) + ', ' + 
                RTRIM(ISNULL(a.Город, '')) + ', ' + 
                RTRIM(ISNULL(a.Улица, '')) AS Адрес,
                o.Название AS Организация
                FROM Контакт k
                LEFT JOIN Адрес a ON k.Id_Адреса = a.Id_Адреса
                LEFT JOIN Место_Работы_Учебы o 
                ON k.Id_Организации = o.Id_Организации";

                _adapter = new SqlDataAdapter(query, connection);
                _dataTable = new DataTable();
                _adapter.Fill(_dataTable);

                _bindingSource = new BindingSource();
                _bindingSource.DataSource = _dataTable;

                ContactDataGridView.AutoGenerateColumns = false;
                ContactDataGridView.DataSource = _bindingSource;
                ContactsBindingNavigator.BindingSource = _bindingSource;

                ContactDataGridView.Columns["NameColumn"].DataPropertyName = "Имя";
                ContactDataGridView.Columns["SurnameColumn"].DataPropertyName = "Фамилия";
                ContactDataGridView.Columns["DateColumn"].DataPropertyName = "Дата_Добавления";
                ContactDataGridView.Columns["AddressColumn"].DataPropertyName = "Адрес";
                ContactDataGridView.Columns["OrganizationColumn"].DataPropertyName = "Организация";
                ContactDataGridView.Columns["PhotoColumn"].DataPropertyName = "Фото_Контакта";
                ContactDataGridView.Columns["PhotoColumn"].Visible = false;
                ContactDataGridView.RowHeadersVisible = false;

                ContactDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ContactDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ContactDataGridView.ReadOnly = true;
                ContactDataGridView.AllowUserToAddRows = false;

                NameTextBox.DataBindings.Clear();
                SurnameTextBox.DataBindings.Clear();
                NameTextBox.DataBindings.Add("Text", _bindingSource, "Имя");
                SurnameTextBox.DataBindings.Add("Text", _bindingSource, "Фамилия");

                DateCreationTimePicker.DataBindings.Clear();
                DateCreationTimePicker.DataBindings.Add(
                    "Value",
                    _bindingSource,
                    "Дата_Добавления",
                    true,
                    DataSourceUpdateMode.OnPropertyChanged,
                    DateTime.Today);

                _bindingSource.PositionChanged += BindingSource_PositionChanged;

                ShowCurrentPhoto();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обрабатывает смену текущей записи.
        /// </summary>
        private void BindingSource_PositionChanged(object sender, EventArgs e)
        {
            ShowCurrentPhoto();
        }

        /// <summary>
        /// Отображает фотографию текущего контакта.
        /// </summary>
        private void ShowCurrentPhoto()
        {
            if (_bindingSource == null || _bindingSource.Current == null)
            {
                PhotoPictureBox.Image = null;
                return;
            }

            DataRowView row = _bindingSource.Current as DataRowView;
            if (row == null) return;

            object photoValue = row["Фото_Контакта"];

            if (photoValue != DBNull.Value)
            {
                byte[] imageBytes = (byte[])photoValue;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    PhotoPictureBox.Image = Image.FromStream(ms);
                }
                PhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                PhotoPictureBox.Image = null;
            }
        }

        /// <summary>
        /// Загружает данные для выпадающих списков.
        /// </summary>
        private void LoadComboBoxes()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetInstance().GetConnection();

                SqlDataAdapter adapterAddress = new SqlDataAdapter("SELECT Id_Адреса, Город + ', ' + Улица AS Адрес FROM Адрес", connection);

                DataTable dtAddress = new DataTable();
                adapterAddress.Fill(dtAddress);

                AddressComboBox.DataSource = dtAddress;
                AddressComboBox.DisplayMember = "Адрес";
                AddressComboBox.ValueMember = "Id_Адреса";

                SqlDataAdapter adapterOrganization = new SqlDataAdapter("SELECT Id_Организации, Название FROM Место_Работы_Учебы", connection);

                DataTable dtOrganization = new DataTable();
                adapterOrganization.Fill(dtOrganization);

                OrganizationComboBox.DataSource = dtOrganization;
                OrganizationComboBox.DisplayMember = "Название";
                OrganizationComboBox.ValueMember = "Id_Организации";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки списков: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Загружает фотографию контакта и сохраняет её в базу данных.
        /// </summary>
        private void UploadPhotoButton_Click(object sender, EventArgs e)
        {
            if (_bindingSource == null || _bindingSource.Current == null)
            {
                MessageBox.Show("Выберите контакт.", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromFile(dialog.FileName);
                    PhotoPictureBox.Image = image;
                    PhotoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    byte[] imageBytes;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        imageBytes = ms.ToArray();
                    }

                    DataRowView currentRow = _bindingSource.Current as DataRowView;
                    int id = Convert.ToInt32(currentRow["Id_Контакта"]);

                    SqlConnection connection =
                        DatabaseConnection.GetInstance().GetConnection();
                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Контакт SET Фото_Контакта=@Фото WHERE Id_Контакта=@Id",
                        connection);
                    cmd.Parameters.AddWithValue("@Фото", imageBytes);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();

                    currentRow["Фото_Контакта"] = imageBytes;

                    MessageBox.Show("Фото сохранено.", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message, "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}