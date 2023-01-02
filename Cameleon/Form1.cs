using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cameleon
{
    public partial class Form1 : Form
    {
        private void showImage ()
        {
            pictureBoxMain.Image = image;
        }

        public Form1()
        {
            InitializeComponent();
        }

        Image image;

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                image = Image.FromFile(openFileDialog.FileName);
            showImage();
        }
    }
}
