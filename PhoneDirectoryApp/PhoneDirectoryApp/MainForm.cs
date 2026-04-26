using System;
using System.Windows.Forms;

namespace PhoneDirectoryApp
{
    /// <summary>
    /// Главная форма приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Хранит текущий экземпляр формы контактов.
        /// </summary>
        private ContactsForm _contactsForm;

        /// <summary>
        /// Хранит текущий экземпляр формы групп.
        /// </summary>
        private GroupsForm _groupsForm;

        /// <summary>
        /// Конструктор главной формы.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие загрузки формы.
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Открывает форму контактов.
        /// Если форма уже открыта — активирует её.
        /// </summary>
        private void OpenContacts()
        {
            if (_contactsForm != null && !_contactsForm.IsDisposed)
            {
                _contactsForm.BringToFront();
                return;
            }

            _contactsForm = new ContactsForm();

            _contactsForm.FormClosed += (s, e) => _contactsForm = null;

            _contactsForm.Show();
        }

        /// <summary>
        /// Открывает форму групп.
        /// Если форма уже открыта — активирует её.
        /// </summary>
        private void OpenGroups()
        {
            if (_groupsForm != null && !_groupsForm.IsDisposed)
            {
                _groupsForm.BringToFront();
                return;
            }

            _groupsForm = new GroupsForm();

            _groupsForm.FormClosed += (s, e) => _groupsForm = null;

            _groupsForm.Show();
        }

        /// <summary>
        /// Завершает работу приложения.
        /// </summary>
        private void ExitApp()
        {
            Application.Exit();
        }

        /// <summary>
        /// Обработчик кнопки открытия контактов.
        /// </summary>
        private void ContactToolStripButton_Click(object sender, EventArgs e)
        {
            OpenContacts();
        }

        /// <summary>
        /// Обработчик кнопки открытия групп.
        /// </summary>
        private void GroupToolStripButton_Click(object sender, EventArgs e)
        {
            OpenGroups();
        }

        /// <summary>
        /// Обработчик кнопки выхода из приложения.
        /// </summary>
        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            ExitApp();
        }
    }
}