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
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Left = Properties.Settings.Default.MainFormLeft;
            this.Top = Properties.Settings.Default.MainFormTop;
            this.Width = Properties.Settings.Default.MainFormWidth;
            this.Height = Properties.Settings.Default.MainFormHeight;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.MainFormLeft = this.Left;
            Properties.Settings.Default.MainFormTop = this.Top;
            Properties.Settings.Default.MainFormWidth = this.Width;
            Properties.Settings.Default.MainFormHeight = this.Height;
            Properties.Settings.Default.Save();
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
        /// Обработчик кнопки открытия контактов в ToolStrip.
        /// </summary>
        private void ContactToolStripButton_Click(object sender, EventArgs e)
        {
            OpenContacts();
        }

        /// <summary>
        /// Обработчик кнопки открытия групп в ToolStrip.
        /// </summary>
        private void GroupToolStripButton_Click(object sender, EventArgs e)
        {
            OpenGroups();
        }

        /// <summary>
        /// Обработчик кнопки выхода из приложения в ToolStrip.
        /// </summary>
        private void ExitToolStripButton_Click(object sender, EventArgs e)
        {
            ExitApp();
        }

        /// <summary>
        /// Обработчик кнопки открытия контактов в ContextMenu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenContacts();
        }

        /// <summary>
        /// Обработчик кнопки открытия групп в ContextMenu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GroupsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenGroups();
        }

        /// <summary>
        /// Обработчик кнопки выхода из приложения в ContextMenu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitApp();
        }
    }
}