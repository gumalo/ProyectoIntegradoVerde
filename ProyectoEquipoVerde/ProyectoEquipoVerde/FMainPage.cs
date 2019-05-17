using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEquipoVerde
{
    public partial class FMainPage : Form
    {


        public FMainPage()
        {
            InitializeComponent();
        }

        private void PicBoxUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            FPerfilUsuario formUsu = new FPerfilUsuario();
            formUsu.ShowDialog();
            this.Close();
        }



        private void PicboxBuscar_MouseClick(object sender, MouseEventArgs e)
        {
            FBusqueda formBusqueda = new FBusqueda();
            formBusqueda.ShowDialog();
            this.Close();
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
