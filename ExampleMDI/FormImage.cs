using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExampleMDI
{
    public partial class FormImage : Form
    {
        public FormImage()
        {
            InitializeComponent();
        }
        private Bitmap m_bmp;
        public void SetFileName(string sImageName)
        {
            try
            {
                m_bmp = new Bitmap(sImageName);
                this.pictureBox1.Image = (Image)m_bmp;
                this.Text = "Зураг" + sImageName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Алдаа: " + ex.ToString());
            }
        }
    }
}
