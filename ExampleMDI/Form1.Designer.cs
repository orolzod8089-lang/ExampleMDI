namespace ExampleMDI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            бүртгэлToolStripMenuItem = new ToolStripMenuItem();
            хэрэглэгчийнБүртгэлToolStripMenuItem = new ToolStripMenuItem();
            хөрөнгийнТаралToolStripMenuItem = new ToolStripMenuItem();
            гарахToolStripMenuItem = new ToolStripMenuItem();
            файлToolStripMenuItem = new ToolStripMenuItem();
            файлНээхToolStripMenuItem = new ToolStripMenuItem();
            цонхToolStripMenuItem = new ToolStripMenuItem();
            хэвтээToolStripMenuItem = new ToolStripMenuItem();
            босооToolStripMenuItem = new ToolStripMenuItem();
            жагсаахToolStripMenuItem = new ToolStripMenuItem();
            хаахToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { бүртгэлToolStripMenuItem, файлToolStripMenuItem, цонхToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // бүртгэлToolStripMenuItem
            // 
            бүртгэлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { хэрэглэгчийнБүртгэлToolStripMenuItem, хөрөнгийнТаралToolStripMenuItem, гарахToolStripMenuItem });
            бүртгэлToolStripMenuItem.Name = "бүртгэлToolStripMenuItem";
            бүртгэлToolStripMenuItem.Size = new Size(75, 24);
            бүртгэлToolStripMenuItem.Text = "Бүртгэл";
            // 
            // хэрэглэгчийнБүртгэлToolStripMenuItem
            // 
            хэрэглэгчийнБүртгэлToolStripMenuItem.Name = "хэрэглэгчийнБүртгэлToolStripMenuItem";
            хэрэглэгчийнБүртгэлToolStripMenuItem.Size = new Size(242, 26);
            хэрэглэгчийнБүртгэлToolStripMenuItem.Text = "Хэрэглэгчийн бүртгэл";
            // 
            // хөрөнгийнТаралToolStripMenuItem
            // 
            хөрөнгийнТаралToolStripMenuItem.Name = "хөрөнгийнТаралToolStripMenuItem";
            хөрөнгийнТаралToolStripMenuItem.Size = new Size(242, 26);
            хөрөнгийнТаралToolStripMenuItem.Text = "Хөрөнгийн тарал";
            // 
            // гарахToolStripMenuItem
            // 
            гарахToolStripMenuItem.Name = "гарахToolStripMenuItem";
            гарахToolStripMenuItem.Size = new Size(242, 26);
            гарахToolStripMenuItem.Text = "Гарах";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { файлНээхToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // файлНээхToolStripMenuItem
            // 
            файлНээхToolStripMenuItem.Name = "файлНээхToolStripMenuItem";
            файлНээхToolStripMenuItem.Size = new Size(162, 26);
            файлНээхToolStripMenuItem.Text = "Файл нээх";
            файлНээхToolStripMenuItem.Click += файлНээхToolStripMenuItem_Click;
            // 
            // цонхToolStripMenuItem
            // 
            цонхToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { хэвтээToolStripMenuItem, босооToolStripMenuItem, жагсаахToolStripMenuItem, хаахToolStripMenuItem });
            цонхToolStripMenuItem.Name = "цонхToolStripMenuItem";
            цонхToolStripMenuItem.Size = new Size(59, 24);
            цонхToolStripMenuItem.Text = "Цонх";
            // 
            // хэвтээToolStripMenuItem
            // 
            хэвтээToolStripMenuItem.Name = "хэвтээToolStripMenuItem";
            хэвтээToolStripMenuItem.Size = new Size(224, 26);
            хэвтээToolStripMenuItem.Text = "Хэвтээ";
            хэвтээToolStripMenuItem.Click += хэвтээToolStripMenuItem_Click;
            // 
            // босооToolStripMenuItem
            // 
            босооToolStripMenuItem.Name = "босооToolStripMenuItem";
            босооToolStripMenuItem.Size = new Size(224, 26);
            босооToolStripMenuItem.Text = "Босоо";
            // 
            // жагсаахToolStripMenuItem
            // 
            жагсаахToolStripMenuItem.Name = "жагсаахToolStripMenuItem";
            жагсаахToolStripMenuItem.Size = new Size(224, 26);
            жагсаахToolStripMenuItem.Text = "Жагсаах";
            жагсаахToolStripMenuItem.Click += жагсаахToolStripMenuItem_Click;
            // 
            // хаахToolStripMenuItem
            // 
            хаахToolStripMenuItem.Name = "хаахToolStripMenuItem";
            хаахToolStripMenuItem.Size = new Size(224, 26);
            хаахToolStripMenuItem.Text = "Хаах";
            хаахToolStripMenuItem.Click += хаахToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem бүртгэлToolStripMenuItem;
        private ToolStripMenuItem хэрэглэгчийнБүртгэлToolStripMenuItem;
        private ToolStripMenuItem хөрөнгийнТаралToolStripMenuItem;
        private ToolStripMenuItem гарахToolStripMenuItem;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem файлНээхToolStripMenuItem;
        private ToolStripMenuItem цонхToolStripMenuItem;
        private ToolStripMenuItem хэвтээToolStripMenuItem;
        private ToolStripMenuItem босооToolStripMenuItem;
        private ToolStripMenuItem жагсаахToolStripMenuItem;
        private ToolStripMenuItem хаахToolStripMenuItem;
    }
}
