using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxRedondo
{
    public partial class frmPrincipal : Form
    {
        OpenFileDialog openFileDialog;
        public frmPrincipal()
        {
            InitializeComponent();
            openFileDialog = new OpenFileDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                roundPicture.ImageLocation = openFileDialog.FileName;
                roundPicture.SizeMode = PictureBoxSizeMode.StretchImage;
                roundPicture.Load();
            }
        }

        private void Grafico_Click(object sender, EventArgs e)
        {
            
        }
    }
}
