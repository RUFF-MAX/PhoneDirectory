using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhoneDirectoryApp
{
    /// <summary>
    /// Форма для отображения и управления группами контактов.
    /// </summary>
    public partial class GroupsForm : Form
    {
        /// <summary>
        /// Адаптер для выполнения SQL-запроса и получения данных.
        /// </summary>
        private SqlDataAdapter _adapter;

        /// <summary>
        /// Локальная таблица для хранения данных из базы.
        /// </summary>
        private DataTable _dataTable;

        /// <summary>
        /// Источник привязки, связывающий данные с элементами интерфейса.
        /// </summary>
        private BindingSource _bindingSource;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public GroupsForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие загрузки формы.
        /// </summary>
        private void GroupsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadComboBoxes();
        }

        /// <summary>
        /// Загружает данные групп из базы данных и настраивает привязку к интерфейсу.
        /// </summary>
        private void LoadData()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetInstance().GetConnection();

                string query = @"SELECT 
                Id_Группы,
                Название_Группы,
                Дата_Создания,
                Статус_Группы,
                Архивная,
                Описание_Группы
                FROM Группа_Контактов";

                _adapter = new SqlDataAdapter(query, connection);
                _dataTable = new DataTable();
                _adapter.Fill(_dataTable);

                _bindingSource = new BindingSource();
                _bindingSource.DataSource = _dataTable;

                GroupsDataGridView.AutoGenerateColumns = false;
                GroupsDataGridView.DataSource = _bindingSource;
                GroupsBindingNavigator.BindingSource = _bindingSource;

                GroupsDataGridView.Columns["GroupNameColumn"].DataPropertyName = "Название_Группы";
                GroupsDataGridView.Columns["DateColumn"].DataPropertyName = "Дата_Создания";
                GroupsDataGridView.Columns["StatusColumn"].DataPropertyName = "Статус_Группы";
                GroupsDataGridView.Columns["ArchivedColumn"].DataPropertyName = "Архивная";
                GroupsDataGridView.Columns["DescriptionColumn"].DataPropertyName = "Описание_Группы";
                GroupsDataGridView.Columns["IdColumn"].Visible = false;
                GroupsDataGridView.RowHeadersVisible = false;

                GroupsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                GroupsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                GroupsDataGridView.ReadOnly = true;
                GroupsDataGridView.AllowUserToAddRows = false;

                NameGroupTextBox.DataBindings.Clear();
                DescriptionTextBox.DataBindings.Clear();
                ArchivedCheckBox.DataBindings.Clear();

                NameGroupTextBox.DataBindings.Add("Text", _bindingSource, "Название_Группы");
                DescriptionTextBox.DataBindings.Add("Text", _bindingSource, "Описание_Группы");
                ArchivedCheckBox.DataBindings.Add("Checked", _bindingSource, "Архивная");

                DateCreationGroupTimePicker.DataBindings.Clear();
                DateCreationGroupTimePicker.DataBindings.Add(
                    "Value",
                    _bindingSource,
                    "Дата_Создания",
                    true,
                    DataSourceUpdateMode.OnPropertyChanged,
                    DateTime.Today);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки данных: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        /// <summary>
        /// Загружает значения для выпадающего списка статуса группы
        /// и привязывает его к данным.
        /// </summary>
        private void LoadComboBoxes()
        {
            StatusComboBox.Items.Clear();

            StatusComboBox.Items.Add("Активная");
            StatusComboBox.Items.Add("Неактивная");

            StatusComboBox.SelectedIndex = 0;

            StatusComboBox.DataBindings.Clear();
            StatusComboBox.DataBindings.Add("Text", _bindingSource, "Статус_Группы");
        }
    }
}