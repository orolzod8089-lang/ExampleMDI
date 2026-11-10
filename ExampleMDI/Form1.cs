namespace ExampleMDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void файлНээхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OF = new OpenFileDialog();
            OF.Filter = "Text files (*.txt)|*.txt|jpg files (*.jpg)|*.jpg|bmp files (*.bmp)|*.bmp|gif files (*.gif)|*.gif|All files (*.*)|*.*";
            if (OF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sFN = OF.FileName;
                    string sExt = sFN.Substring(sFN.LastIndexOf("."));
                    sExt = sExt.ToUpper();
                    if (sExt == ".BMP" || sExt == ".JPG" || sExt == ".GIF")
                    {
                        FormImage imgForm = new FormImage();
                        imgForm.SetFileName(sFN);
                        imgForm.MdiParent = this;
                        imgForm.Show();
                    }
                    else
                        if (sExt == ".TXT" || sExt == ".CS")
                        {
                            FormText txtForm = new FormText();
                            txtForm.SetFileName(sFN);
                            txtForm.MdiParent = this;
                            txtForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Уучлаарай. Файлыг нээж чадахгүй.");
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Алдаа: " + ex.ToString());
                }
            }
        }

        private void хаахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                MdiChildren[0].Dispose();
            }
        }

        private void жагсаахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void хэвтээToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void босооToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
    }
}