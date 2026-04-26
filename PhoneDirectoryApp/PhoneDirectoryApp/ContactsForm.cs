using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PhoneDirectoryApp
{
    /// <summary>
    /// Форма для отображения и управления контактами.
    /// </summary>
    public partial class ContactsForm : Form
    {
        /// <summary>
        /// Конструктор формы. Инициализирует все компоненты, созданные в дизайнере.
        /// </summary>
        public ContactsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Адаптер для получения данных из базы данных.
        /// </summary>
        private SqlDataAdapter _adapter;

        /// <summary>
        /// Таблица данных, содержащая контакты.
        /// </summary>
        private DataTable _dataTable;

        /// <summary>
        /// Источник привязки данных для синхронизации UI и данных.
        /// </summary>
        private BindingSource _bindingSource;

        /// <summary>
        /// Событие загрузки формы.
        /// </summary>
        private void ContactsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxes();
        }

        /// <summary>
        /// Загружает данные контактов из базы данных и связывает их с элементами UI.
        /// </summary>
        private void LoadData()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetInstance().GetConnection();
                string query = @"SELECT 
                k.id_контакта,
                k.имя,
                k.фамилия,
                k.дата_добавления,
                k.фото_контакта,
                a.город + ', ' + a.улица AS адрес,
                o.название AS организация
            FROM КОНТАКТ k
            LEFT JOIN АДРЕС a ON k.id_адреса = a.id_адреса
            LEFT JOIN МЕСТО_РАБОТЫ_УЧЕБЫ o ON k.id_организации = o.id_организации";

                _adapter = new SqlDataAdapter(query, connection);
                _dataTable = new DataTable();
                _adapter.Fill(_dataTable);

                _bindingSource = new BindingSource();
                _bindingSource.DataSource = _dataTable;

                ContactDataGridView.DataSource = _bindingSource;
                ContactsBindingNavigator.BindingSource = _bindingSource;

                NameTextBox.DataBindings.Clear();
                SurnameTextBox.DataBindings.Clear();
                NameTextBox.DataBindings.Add("Text", _bindingSource, "имя");
                SurnameTextBox.DataBindings.Add("Text", _bindingSource, "фамилия");

                ContactDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ContactDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ContactDataGridView.ReadOnly = true;
                ContactDataGridView.AllowUserToAddRows = false;
                ContactDataGridView.Columns["id_контакта"].Visible = false;
                ContactDataGridView.Columns["фото_контакта"].Visible = false;

                ContactDataGridView.Columns["имя"].DataPropertyName = "имя";
                ContactDataGridView.Columns["фамилия"].DataPropertyName = "фамилия";
                ContactDataGridView.Columns["дата_добавления"].DataPropertyName = "дата_добавления";
                ContactDataGridView.Columns["адрес"].DataPropertyName = "адрес";
                ContactDataGridView.Columns["организация"].DataPropertyName = "организация";

                _bindingSource.PositionChanged += BindingSource_PositionChanged;
                ShowCurrentPhoto();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик изменения текущей позиции в BindingSource.
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

            object PhotoValue = row["фото_контакта"];

            if (PhotoValue != null && PhotoValue != DBNull.Value)
            {
                byte[] imageBytes = (byte[])PhotoValue;
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    PhotoPictureBox.Image = new Bitmap(Image.FromStream(ms));
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

                SqlDataAdapter adapterAddress = new SqlDataAdapter(
                "SELECT id_адреса, город + ', ' + улица AS адрес FROM АДРЕС", connection);
                DataTable dtAddress = new DataTable();
                adapterAddress.Fill(dtAddress);

                AddressComboBox.DataSource = dtAddress;
                AddressComboBox.DisplayMember = "Адрес";
                AddressComboBox.ValueMember = "id_адреса";

                SqlDataAdapter adapterOrganization = new SqlDataAdapter(
                "SELECT id_организации, название FROM МЕСТО_РАБОТЫ_УЧЕБЫ", connection);
                DataTable dtOrganization = new DataTable();
                adapterOrganization.Fill(dtOrganization);

                OrganizationComboBox.DataSource = dtOrganization;
                OrganizationComboBox.DisplayMember = "Название";
                OrganizationComboBox.ValueMember = "id_организации";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки списков: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Загрузить фото".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadPhotoButton_Click(object sender, EventArgs e)
        {
            if (ContactDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Выберите контакт в таблице.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp";
            dialog.Title = "Выберите фото контакта";

            if (dialog.ShowDialog() == DialogResult.OK)
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

                int idКонтакта = Convert.ToInt32(ContactDataGridView.CurrentRow.Cells["id_контакта"].Value);
                SqlConnection connection =
                        DatabaseConnection.GetInstance().GetConnection();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE КОНТАКТ SET фото_контакта = @фото " +
                    "WHERE id_контакта = @id", connection);
                cmd.Parameters.AddWithValue("@фото", imageBytes);
                cmd.Parameters.AddWithValue("@id", idКонтакта);
                cmd.ExecuteNonQuery();

                DataRowView row = _bindingSource.Current as DataRowView;
                if (row != null)
                {
                    row["фото_контакта"] = imageBytes;
                }

                MessageBox.Show("Фото сохранено успешно.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
