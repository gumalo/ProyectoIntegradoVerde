using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProyectoEquipoVerde
{
    public partial class FPerfilPeli : Form
    {
        public FPerfilPeli()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FPerfilPeli_Load(object sender, EventArgs e)
        {

        }

        private void BtnHeaderInicio_Click(object sender, EventArgs e)
        {

        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHeaderFB_Click(object sender, EventArgs e)
        {
            Process.Start("https://es-es.facebook.com/");
        }

        private void BtnHeaderInsta_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/?hl=es");
        }

        private void BtnHeaderTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/");
        }
    }
}
