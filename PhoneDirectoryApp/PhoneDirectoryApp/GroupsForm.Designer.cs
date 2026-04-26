namespace PhoneDirectoryApp
{
    partial class GroupsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsForm));
            this.GroupsDataGridView = new System.Windows.Forms.DataGridView();
            this.GroupPanel = new System.Windows.Forms.Panel();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ArchivedCheckBox = new System.Windows.Forms.CheckBox();
            this.DateCreationGroupTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DateCreationLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.NameGroupTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.GroupsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.GroupNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ArchivedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).BeginInit();
            this.GroupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsBindingNavigator)).BeginInit();
            this.GroupsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupsDataGridView
            // 
            this.GroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GroupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GroupNameColumn,
            this.DateColumn,
            this.StatusColumn,
            this.ArchivedColumn,
            this.DescriptionColumn,
            this.IdColumn});
            this.GroupsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.GroupsDataGridView.Name = "GroupsDataGridView";
            this.GroupsDataGridView.Size = new System.Drawing.Size(800, 271);
            this.GroupsDataGridView.TabIndex = 0;
            // 
            // GroupPanel
            // 
            this.GroupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GroupPanel.Controls.Add(this.DescriptionTextBox);
            this.GroupPanel.Controls.Add(this.DescriptionLabel);
            this.GroupPanel.Controls.Add(this.ArchivedCheckBox);
            this.GroupPanel.Controls.Add(this.DateCreationGroupTimePicker);
            this.GroupPanel.Controls.Add(this.DateCreationLabel);
            this.GroupPanel.Controls.Add(this.StatusComboBox);
            this.GroupPanel.Controls.Add(this.StatusLabel);
            this.GroupPanel.Controls.Add(this.NameGroupTextBox);
            this.GroupPanel.Controls.Add(this.NameLabel);
            this.GroupPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupPanel.Location = new System.Drawing.Point(0, 271);
            this.GroupPanel.Name = "GroupPanel";
            this.GroupPanel.Size = new System.Drawing.Size(800, 179);
            this.GroupPanel.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(428, 59);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(359, 91);
            this.DescriptionTextBox.TabIndex = 9;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(359, 62);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(63, 13);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ArchivedCheckBox
            // 
            this.ArchivedCheckBox.AutoSize = true;
            this.ArchivedCheckBox.Location = new System.Drawing.Point(362, 30);
            this.ArchivedCheckBox.Name = "ArchivedCheckBox";
            this.ArchivedCheckBox.Size = new System.Drawing.Size(68, 17);
            this.ArchivedCheckBox.TabIndex = 7;
            this.ArchivedCheckBox.Text = "Archived";
            this.ArchivedCheckBox.UseVisualStyleBackColor = true;
            // 
            // DateCreationGroupTimePicker
            // 
            this.DateCreationGroupTimePicker.Location = new System.Drawing.Point(114, 90);
            this.DateCreationGroupTimePicker.Name = "DateCreationGroupTimePicker";
            this.DateCreationGroupTimePicker.Size = new System.Drawing.Size(127, 20);
            this.DateCreationGroupTimePicker.TabIndex = 5;
            // 
            // DateCreationLabel
            // 
            this.DateCreationLabel.AutoSize = true;
            this.DateCreationLabel.Location = new System.Drawing.Point(33, 96);
            this.DateCreationLabel.Name = "DateCreationLabel";
            this.DateCreationLabel.Size = new System.Drawing.Size(75, 13);
            this.DateCreationLabel.TabIndex = 4;
            this.DateCreationLabel.Text = "Date Creation:";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(114, 59);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(127, 21);
            this.StatusComboBox.TabIndex = 3;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(35, 62);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status:";
            // 
            // NameGroupTextBox
            // 
            this.NameGroupTextBox.Location = new System.Drawing.Point(114, 27);
            this.NameGroupTextBox.Name = "NameGroupTextBox";
            this.NameGroupTextBox.Size = new System.Drawing.Size(127, 20);
            this.NameGroupTextBox.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(35, 30);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // GroupsBindingNavigator
            // 
            this.GroupsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.GroupsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.GroupsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.GroupsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.GroupsBindingNavigator.Location = new System.Drawing.Point(0, 425);
            this.GroupsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.GroupsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.GroupsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.GroupsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.GroupsBindingNavigator.Name = "GroupsBindingNavigator";
            this.GroupsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.GroupsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.GroupsBindingNavigator.TabIndex = 2;
            this.GroupsBindingNavigator.Text = "GroupsBindingNavigator";
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
            // GroupNameColumn
            // 
            this.GroupNameColumn.HeaderText = "Group name";
            this.GroupNameColumn.Name = "GroupNameColumn";
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            // 
            // ArchivedColumn
            // 
            this.ArchivedColumn.HeaderText = "Archived";
            this.ArchivedColumn.Name = "ArchivedColumn";
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.HeaderText = "Description";
            this.DescriptionColumn.Name = "DescriptionColumn";
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "IdColumn";
            this.IdColumn.Name = "IdColumn";
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GroupsBindingNavigator);
            this.Controls.Add(this.GroupPanel);
            this.Controls.Add(this.GroupsDataGridView);
            this.Name = "GroupsForm";
            this.Text = "GroupsForm";
            this.Load += new System.EventHandler(this.GroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupsDataGridView)).EndInit();
            this.GroupPanel.ResumeLayout(false);
            this.GroupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupsBindingNavigator)).EndInit();
            this.GroupsBindingNavigator.ResumeLayout(false);
            this.GroupsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GroupsDataGridView;
        private System.Windows.Forms.Panel GroupPanel;
        private System.Windows.Forms.BindingNavigator GroupsBindingNavigator;
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
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DateTimePicker DateCreationGroupTimePicker;
        private System.Windows.Forms.Label DateCreationLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox NameGroupTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.CheckBox ArchivedCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ArchivedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
    }
}