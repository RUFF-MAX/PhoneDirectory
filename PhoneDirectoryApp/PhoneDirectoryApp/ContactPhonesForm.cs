using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PhoneDirectoryApp
{
    public partial class ContactPhonesForm : Form
    {
        public ContactPhonesForm()
        {
            InitializeComponent();
        }

        private DataTable _contactsTable;
        private DataTable _phonesTable;
        private BindingSource _contactsSource;
        private BindingSource _phonesSource;

        private void LoadContacts()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetInstance().GetConnection();

                string query = @"SELECT
                k.Id_Контакта,
                k.Имя,
                k.Фамилия,
                k.Имя + ' ' + k.Фамилия AS Полное_Имя,
                k.Дата_Добавления,
                DATEDIFF(day, k.Дата_Добавления, GETDATE())
                k.Id_Адреса,
                k.Id_Организации,
                RTRIM(ISNULL(a.Страна,'')) + ', ' +
                RTRIM(ISNULL(a.Город,'')) AS Адрес_Текст,
                ISNULL(o.Название,'') AS Организация_Текст
            FROM Контакт k
            LEFT JOIN Адрес a ON k.Id_Адреса = a.Id_Адреса
            LEFT JOIN Место_Работы_Учебы o 
            ON k.Id_Организации = o.Id_Организации";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                _contactsTable = new DataTable();
                adapter.Fill(_contactsTable);

                DataColumn fullNameCol = new DataColumn(
                        "Fullname",
                        typeof(string),
                        "Фамилия + ' ' + Имя");
                _contactsTable.Columns.Add(fullNameCol);

                _contactsSource = new BindingSource();
                _contactsSource.DataSource = _contactsTable;

                ContactsDataGridView.AutoGenerateColumns = false;
                ContactsDataGridView.DataSource = _contactsSource;
                ContactsBindingNavigator.BindingSource = _contactsSource;

                ContactsDataGridView.Columns["FullNameColumn"].DataPropertyName = "Fullname";
                ContactsDataGridView.Columns["DaysColumn"].DataPropertyName = "Days";
                ContactsDataGridView.Columns["AddressTextColumn"].DataPropertyName = "Address";
                ContactsDataGridView.Columns["OrgTextColumn"].DataPropertyName = "Organization";

                ContactsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ContactsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ContactsDataGridView.ReadOnly = true;
                ContactsDataGridView.AllowUserToAddRows = false;
                ContactsDataGridView.RowHeadersVisible = false;

                _contactsSource.PositionChanged += ContactsSource_PositionChanged;
                LoadPhones();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Ошибка базы данных при загрузке контактов:\n" +
                    ex.Message,
                    "Ошибка БД",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Неожиданная ошибка: " + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void SetupLookupColumns()
        {
            try
            {
                SqlConnection connection = DatabaseConnection.GetInstance().GetConnection();

                SqlDataAdapter addrAdapter = new SqlDataAdapter(
                    @"SELECT Id_Адреса, 
                      RTRIM(ISNULL(Страна,'')) + ', ' + 
                      RTRIM(ISNULL(Город,'')) AS Адрес 
                      FROM Адрес", connection);
                DataTable dtAddr = new DataTable();
                addrAdapter.Fill(dtAddr);

                DataGridViewComboBoxColumn addrCol = ContactsDataGridView.Columns["AddressLookupColumn"] as DataGridViewComboBoxColumn;

                if (addrCol != null)
                {
                    addrCol.DataSource = dtAddr;
                    addrCol.DisplayMember = "Адрес";
                    addrCol.ValueMember = "Id_Адреса";
                    addrCol.DataPropertyName = "Id_Адреса";
                }

                SqlDataAdapter orgAdapter = new SqlDataAdapter("SELECT Id_Организации, Название FROM Место_Работы_Учебы", connection);
                DataTable dtOrg = new DataTable();
                orgAdapter.Fill(dtOrg);
                DataGridViewComboBoxColumn orgCol = ContactsDataGridView.Columns["OrgLookupColumn"] as DataGridViewComboBoxColumn;

                if (orgCol != null)
                {
                    orgCol.DataSource = dtOrg;
                    orgCol.DisplayMember = "Название";
                    orgCol.ValueMember = "Id_Организации";
                    orgCol.DataPropertyName = "Id_Организации";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Ошибка загрузки справочников:\n" + ex.Message,
                    "Ошибка БД",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadPhones()
        {
            try
            {
                if (_contactsSource == null || _contactsSource.Current == null)
                {
                    return;
                }

                DataRowView row = _contactsSource.Current as DataRowView;
                if (row != null)
                {
                    return;
                }

                int ContactId = Convert.ToInt32(row["Id_Контакта"]);
                SqlConnection connection = DatabaseConnection.GetInstance().GetConnection();

                string query = @"SELECT
                    Id_Телефона,
                    Тип,
                    Телефонная_Нумерация,
                    Тип + ': ' + RTRIM(Телефонная_Нумерация) 
                    AS Полный_Номер
                FROM Номер_Телефона
                WHERE Id_Контакта = @Id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@Id", ContactId);

                _phonesTable = new DataTable();
                adapter.Fill(_phonesTable);
                _phonesSource = new BindingSource();
                _phonesSource.DataSource = _phonesTable;

                PhonesDataGridView.AutoGenerateColumns = false;
                PhonesDataGridView.DataSource = _phonesSource;
                PhonesBindingNavigator.BindingSource = _phonesSource;

                PhonesDataGridView.Columns["PhoneTypeColumn"].DataPropertyName = "Type";
                PhonesDataGridView.Columns["PhoneNumberColumn"].DataPropertyName = "PhoneNumber";
                PhonesDataGridView.Columns["PhoneFullColumn"].DataPropertyName = "FullPhone";

                PhonesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PhonesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                PhonesDataGridView.ReadOnly = true;
                PhonesDataGridView.AllowUserToAddRows = false;
                PhonesDataGridView.RowHeadersVisible = false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Ошибка загрузки телефонов:\n" + ex.Message,
                    "Ошибка БД",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(
                    "Ошибка операции: " + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ContactsSource_PositionChanged(object sender, EventArgs e)
        {
            LoadPhones();
        }

        private void ContactPhonesForm_Load(object sender, EventArgs e)
        {
            LoadContacts();
            SetupLookupColumns();
        }

        private void ApplyFilter()
        {
            try
            {
                string searchText = SearchTextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(searchText))
                {
                    _contactsTable.DefaultView.RowFilter = "";
                    return;
                }

                string filter = string.Format(
                    "Имя LIKE '%{0}%' OR " +
                    "Фамилия LIKE '%{0}%' OR " +
                    "Адрес_Текст LIKE '%{0}%'",
                    searchText);

                _contactsTable.DefaultView.RowFilter = filter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка фильтрации: " + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SearchTextBox.Text = "";
            _contactsTable.DefaultView.RowFilter = "";
            LoadPhones();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }
    }
}
