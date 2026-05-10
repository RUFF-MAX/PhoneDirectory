namespace PhoneDirectoryApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.ContactToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.GroupToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SeparatorToolStripButton = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.СontextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip.SuspendLayout();
            this.СontextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContactToolStripButton,
            this.GroupToolStripButton,
            this.SeparatorToolStripButton,
            this.ExitToolStripButton});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(884, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // ContactToolStripButton
            // 
            this.ContactToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ContactToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ContactToolStripButton.Image")));
            this.ContactToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ContactToolStripButton.Name = "ContactToolStripButton";
            this.ContactToolStripButton.Size = new System.Drawing.Size(58, 22);
            this.ContactToolStripButton.Text = "Contacts";
            this.ContactToolStripButton.Click += new System.EventHandler(this.ContactToolStripButton_Click);
            // 
            // GroupToolStripButton
            // 
            this.GroupToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GroupToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GroupToolStripButton.Image")));
            this.GroupToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupToolStripButton.Name = "GroupToolStripButton";
            this.GroupToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.GroupToolStripButton.Text = "Groups";
            this.GroupToolStripButton.Click += new System.EventHandler(this.GroupToolStripButton_Click);
            // 
            // SeparatorToolStripButton
            // 
            this.SeparatorToolStripButton.Name = "SeparatorToolStripButton";
            this.SeparatorToolStripButton.Size = new System.Drawing.Size(6, 25);
            // 
            // ExitToolStripButton
            // 
            this.ExitToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ExitToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitToolStripButton.Image")));
            this.ExitToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExitToolStripButton.Name = "ExitToolStripButton";
            this.ExitToolStripButton.Size = new System.Drawing.Size(30, 22);
            this.ExitToolStripButton.Text = "Exit";
            this.ExitToolStripButton.Click += new System.EventHandler(this.ExitToolStripButton_Click);
            // 
            // СontextMenuStrip
            // 
            this.СontextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContactsToolStripMenuItem,
            this.GroupsToolStripMenuItem1,
            this.ExitToolStripMenuItem});
            this.СontextMenuStrip.Name = "contextMenuStrip1";
            this.СontextMenuStrip.Size = new System.Drawing.Size(127, 70);
            // 
            // ContactsToolStripMenuItem
            // 
            this.ContactsToolStripMenuItem.Name = "ContactsToolStripMenuItem";
            this.ContactsToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ContactsToolStripMenuItem.Text = "Контакты";
            this.ContactsToolStripMenuItem.Click += new System.EventHandler(this.ContactsToolStripMenuItem_Click);
            // 
            // GroupsToolStripMenuItem1
            // 
            this.GroupsToolStripMenuItem1.Name = "GroupsToolStripMenuItem1";
            this.GroupsToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.GroupsToolStripMenuItem1.Text = "Группы";
            this.GroupsToolStripMenuItem1.Click += new System.EventHandler(this.GroupsToolStripMenuItem1_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.ExitToolStripMenuItem.Text = "Выход";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ContextMenuStrip = this.СontextMenuStrip;
            this.Controls.Add(this.MainToolStrip);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Contacts Directory";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.СontextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton ContactToolStripButton;
        private System.Windows.Forms.ToolStripButton GroupToolStripButton;
        private System.Windows.Forms.ToolStripButton ExitToolStripButton;
        private System.Windows.Forms.ContextMenuStrip СontextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ContactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GroupsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator SeparatorToolStripButton;
    }
}

