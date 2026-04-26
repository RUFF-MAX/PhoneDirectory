namespace PhoneDirectoryApp
{
    partial class ContactsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            this.ContactDataGridView = new System.Windows.Forms.DataGridView();
            this.ContactsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.EditingPanel = new System.Windows.Forms.Panel();
            this.OrganizationLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.PhotoLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.UploadPhotoButton = new System.Windows.Forms.Button();
            this.DateCreationTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddressComboBox = new System.Windows.Forms.ComboBox();
            this.OrganizationComboBox = new System.Windows.Forms.ComboBox();
            this.BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.OrganizationColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.PhotoColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ContactDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsBindingNavigator)).BeginInit();
            this.ContactsBindingNavigator.SuspendLayout();
            this.EditingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ContactDataGridView
            // 
            this.ContactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContactDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.SurnameColumn,
            this.DateColumn,
            this.AddressColumn,
            this.OrganizationColumn,
            this.PhotoColumn});
            this.ContactDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContactDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ContactDataGridView.Name = "ContactDataGridView";
            this.ContactDataGridView.Size = new System.Drawing.Size(800, 450);
            this.ContactDataGridView.TabIndex = 0;
            // 
            // ContactsBindingNavigator
            // 
            this.ContactsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.ContactsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.ContactsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.ContactsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContactsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.BindingNavigatorSaveItem});
            this.ContactsBindingNavigator.Location = new System.Drawing.Point(0, 425);
            this.ContactsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.ContactsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.ContactsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.ContactsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.ContactsBindingNavigator.Name = "ContactsBindingNavigator";
            this.ContactsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.ContactsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.ContactsBindingNavigator.TabIndex = 1;
            this.ContactsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // EditingPanel
            // 
            this.EditingPanel.BackColor = System.Drawing.SystemColors.Control;
            this.EditingPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditingPanel.Controls.Add(this.OrganizationComboBox);
            this.EditingPanel.Controls.Add(this.AddressComboBox);
            this.EditingPanel.Controls.Add(this.DateCreationTimePicker);
            this.EditingPanel.Controls.Add(this.UploadPhotoButton);
            this.EditingPanel.Controls.Add(this.PhotoPictureBox);
            this.EditingPanel.Controls.Add(this.PhotoLabel);
            this.EditingPanel.Controls.Add(this.OrganizationLabel);
            this.EditingPanel.Controls.Add(this.AddressLabel);
            this.EditingPanel.Controls.Add(this.label1);
            this.EditingPanel.Controls.Add(this.NameTextBox);
            this.EditingPanel.Controls.Add(this.SurnameTextBox);
            this.EditingPanel.Controls.Add(this.SurnameLabel);
            this.EditingPanel.Controls.Add(this.Namelabel);
            this.EditingPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EditingPanel.Location = new System.Drawing.Point(0, 275);
            this.EditingPanel.Name = "EditingPanel";
            this.EditingPanel.Size = new System.Drawing.Size(800, 150);
            this.EditingPanel.TabIndex = 2;
            // 
            // OrganizationLabel
            // 
            this.OrganizationLabel.AutoSize = true;
            this.OrganizationLabel.Location = new System.Drawing.Point(264, 57);
            this.OrganizationLabel.Name = "OrganizationLabel";
            this.OrganizationLabel.Size = new System.Drawing.Size(69, 13);
            this.OrganizationLabel.TabIndex = 7;
            this.OrganizationLabel.Text = "Organization:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(264, 23);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(84, 20);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(128, 20);
            this.NameTextBox.TabIndex = 3;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(84, 54);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(128, 20);
            this.SurnameTextBox.TabIndex = 2;
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(26, 57);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(52, 13);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Surname:";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Location = new System.Drawing.Point(26, 23);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(38, 13);
            this.Namelabel.TabIndex = 0;
            this.Namelabel.Text = "Name:";
            // 
            // PhotoLabel
            // 
            this.PhotoLabel.AutoSize = true;
            this.PhotoLabel.Location = new System.Drawing.Point(624, 9);
            this.PhotoLabel.Name = "PhotoLabel";
            this.PhotoLabel.Size = new System.Drawing.Size(35, 13);
            this.PhotoLabel.TabIndex = 10;
            this.PhotoLabel.Text = "Photo";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPictureBox.Location = new System.Drawing.Point(588, 25);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(110, 110);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 11;
            this.PhotoPictureBox.TabStop = false;
            // 
            // UploadPhotoButton
            // 
            this.UploadPhotoButton.Location = new System.Drawing.Point(704, 70);
            this.UploadPhotoButton.Name = "UploadPhotoButton";
            this.UploadPhotoButton.Size = new System.Drawing.Size(83, 34);
            this.UploadPhotoButton.TabIndex = 12;
            this.UploadPhotoButton.Text = "Upload Photo";
            this.UploadPhotoButton.UseVisualStyleBackColor = true;
            this.UploadPhotoButton.Click += new System.EventHandler(this.UploadPhotoButton_Click);
            // 
            // DateCreationTimePicker
            // 
            this.DateCreationTimePicker.Location = new System.Drawing.Point(84, 91);
            this.DateCreationTimePicker.Name = "DateCreationTimePicker";
            this.DateCreationTimePicker.Size = new System.Drawing.Size(128, 20);
            this.DateCreationTimePicker.TabIndex = 13;
            // 
            // AddressComboBox
            // 
            this.AddressComboBox.FormattingEnabled = true;
            this.AddressComboBox.Location = new System.Drawing.Point(339, 23);
            this.AddressComboBox.Name = "AddressComboBox";
            this.AddressComboBox.Size = new System.Drawing.Size(191, 21);
            this.AddressComboBox.TabIndex = 14;
            // 
            // OrganizationComboBox
            // 
            this.OrganizationComboBox.FormattingEnabled = true;
            this.OrganizationComboBox.Location = new System.Drawing.Point(339, 57);
            this.OrganizationComboBox.Name = "OrganizationComboBox";
            this.OrganizationComboBox.Size = new System.Drawing.Size(191, 21);
            this.OrganizationComboBox.TabIndex = 15;
            // 
            // BindingNavigatorSaveItem
            // 
            this.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("BindingNavigatorSaveItem.Image")));
            this.BindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem";
            this.BindingNavigatorSaveItem.Size = new System.Drawing.Size(35, 22);
            this.BindingNavigatorSaveItem.Text = "Save";
            this.BindingNavigatorSaveItem.ToolTipText = "Сохранить изменения в базу данных";
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // SurnameColumn
            // 
            this.SurnameColumn.HeaderText = "Surname";
            this.SurnameColumn.Name = "SurnameColumn";
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date Creation";
            this.DateColumn.Name = "DateColumn";
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            // 
            // OrganizationColumn
            // 
            this.OrganizationColumn.HeaderText = "Organization";
            this.OrganizationColumn.Name = "OrganizationColumn";
            // 
            // PhotoColumn
            // 
            this.PhotoColumn.HeaderText = "Photo";
            this.PhotoColumn.Name = "PhotoColumn";
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditingPanel);
            this.Controls.Add(this.ContactsBindingNavigator);
            this.Controls.Add(this.ContactDataGridView);
            this.Name = "ContactsForm";
            this.Text = "ContactsForm";
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ContactDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactsBindingNavigator)).EndInit();
            this.ContactsBindingNavigator.ResumeLayout(false);
            this.ContactsBindingNavigator.PerformLayout();
            this.EditingPanel.ResumeLayout(false);
            this.EditingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ContactDataGridView;
        private System.Windows.Forms.BindingNavigator ContactsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel EditingPanel;
        private System.Windows.Forms.Label OrganizationLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Button UploadPhotoButton;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.Label PhotoLabel;
        private System.Windows.Forms.ComboBox OrganizationComboBox;
        private System.Windows.Forms.ComboBox AddressComboBox;
        private System.Windows.Forms.DateTimePicker DateCreationTimePicker;
        private System.Windows.Forms.ToolStripButton BindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn OrganizationColumn;
        private System.Windows.Forms.DataGridViewImageColumn PhotoColumn;
    }
}