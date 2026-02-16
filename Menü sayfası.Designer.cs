namespace belge
{
    partial class Menü_sayfası
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
            menuStrip1 = new MenuStrip();
            sINIFSEÇİMİToolStripMenuItem = new ToolStripMenuItem();
            sINIFLARToolStripMenuItem = new ToolStripMenuItem();
            bÖLÜMLERToolStripMenuItem = new ToolStripMenuItem();
            bilişimToolStripMenuItem = new ToolStripMenuItem();
            elektrikToolStripMenuItem = new ToolStripMenuItem();
            hazırlıkToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            sınıflarToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sINIFSEÇİMİToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(843, 53);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sINIFSEÇİMİToolStripMenuItem
            // 
            sINIFSEÇİMİToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sINIFLARToolStripMenuItem, sınıflarToolStripMenuItem });
            sINIFSEÇİMİToolStripMenuItem.Font = new Font("Tahoma", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sINIFSEÇİMİToolStripMenuItem.Name = "sINIFSEÇİMİToolStripMenuItem";
            sINIFSEÇİMİToolStripMenuItem.Size = new Size(293, 49);
            sINIFSEÇİMİToolStripMenuItem.Text = "SINIF SEÇİMİ";
            // 
            // sINIFLARToolStripMenuItem
            // 
            sINIFLARToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bÖLÜMLERToolStripMenuItem, bilişimToolStripMenuItem, elektrikToolStripMenuItem, hazırlıkToolStripMenuItem });
            sINIFLARToolStripMenuItem.Font = new Font("Tahoma", 24F, FontStyle.Regular, GraphicsUnit.Point, 162);
            sINIFLARToolStripMenuItem.Name = "sINIFLARToolStripMenuItem";
            sINIFLARToolStripMenuItem.Size = new Size(259, 44);
            sINIFLARToolStripMenuItem.Text = "9.SINIFLAR";
            // 
            // bÖLÜMLERToolStripMenuItem
            // 
            bÖLÜMLERToolStripMenuItem.Font = new Font("Tahoma", 20.25F);
            bÖLÜMLERToolStripMenuItem.Name = "bÖLÜMLERToolStripMenuItem";
            bÖLÜMLERToolStripMenuItem.Size = new Size(282, 38);
            bÖLÜMLERToolStripMenuItem.Text = "BÖLÜMLER";
            // 
            // bilişimToolStripMenuItem
            // 
            bilişimToolStripMenuItem.Font = new Font("Tahoma", 20.25F);
            bilişimToolStripMenuItem.Name = "bilişimToolStripMenuItem";
            bilişimToolStripMenuItem.Size = new Size(282, 38);
            bilişimToolStripMenuItem.Text = "Bilişim";
            bilişimToolStripMenuItem.Click += bilişimToolStripMenuItem_Click;
            // 
            // elektrikToolStripMenuItem
            // 
            elektrikToolStripMenuItem.Font = new Font("Tahoma", 20.25F);
            elektrikToolStripMenuItem.Name = "elektrikToolStripMenuItem";
            elektrikToolStripMenuItem.Size = new Size(282, 38);
            elektrikToolStripMenuItem.Text = "Elektrik";
            elektrikToolStripMenuItem.Click += elektrikToolStripMenuItem_Click;
            // 
            // hazırlıkToolStripMenuItem
            // 
            hazırlıkToolStripMenuItem.Font = new Font("Tahoma", 20.25F);
            hazırlıkToolStripMenuItem.Name = "hazırlıkToolStripMenuItem";
            hazırlıkToolStripMenuItem.Size = new Size(282, 38);
            hazırlıkToolStripMenuItem.Text = "HAZIRLIK SINIF";
            hazırlıkToolStripMenuItem.Click += hazırlıkToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(392, 223);
            label1.Name = "label1";
            label1.Size = new Size(451, 111);
            label1.TabIndex = 1;
            label1.Text = "Üs tarafdaki sınıf seç menüsünden \r\nHangi sınıf olduğunu seçin ardından \r\nHangi bölüm olduğunu seçiniz\r\n";
            // 
            // sınıflarToolStripMenuItem
            // 
            sınıflarToolStripMenuItem.Font = new Font("Tahoma", 24F);
            sınıflarToolStripMenuItem.Name = "sınıflarToolStripMenuItem";
            sınıflarToolStripMenuItem.Size = new Size(259, 44);
            sınıflarToolStripMenuItem.Text = "10.Sınıflar";
            // 
            // Menü_sayfası
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(843, 356);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menü_sayfası";
            Text = "MENÜ SAYFASI";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sINIFSEÇİMİToolStripMenuItem;
        private ToolStripMenuItem sINIFLARToolStripMenuItem;
        private ToolStripMenuItem bÖLÜMLERToolStripMenuItem;
        private ToolStripMenuItem bilişimToolStripMenuItem;
        private ToolStripMenuItem elektrikToolStripMenuItem;
        private ToolStripMenuItem hazırlıkToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem sınıflarToolStripMenuItem;
    }
}