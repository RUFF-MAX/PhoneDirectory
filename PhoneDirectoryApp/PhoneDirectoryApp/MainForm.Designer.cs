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
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ContactToolStripButton.Size = new System.Drawing.Size(63, 22);
            this.ContactToolStripButton.Text = "Контакты";
            this.ContactToolStripButton.Click += new System.EventHandler(this.ContactToolStripButton_Click);
            // 
            // GroupToolStripButton
            // 
            this.GroupToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GroupToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("GroupToolStripButton.Image")));
            this.GroupToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupToolStripButton.Name = "GroupToolStripButton";
            this.GroupToolStripButton.Size = new System.Drawing.Size(53, 22);
            this.GroupToolStripButton.Text = "Группы";
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
            this.обновитьToolStripMenuItem,
            this.обновитьToolStripMenuItem1,
            this.выходToolStripMenuItem});
            this.СontextMenuStrip.Name = "contextMenuStrip1";
            this.СontextMenuStrip.Size = new System.Drawing.Size(129, 70);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Открыть";
            // 
            // обновитьToolStripMenuItem1
            // 
            this.обновитьToolStripMenuItem1.Name = "обновитьToolStripMenuItem1";
            this.обновитьToolStripMenuItem1.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem1.Text = "Обновить";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.выходToolStripMenuItem.Text = "Выход";
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
            this.Text = "Телефонный справочник";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator SeparatorToolStripButton;
    }
}

