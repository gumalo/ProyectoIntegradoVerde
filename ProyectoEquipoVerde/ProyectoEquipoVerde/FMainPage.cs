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
    public partial class FMainPage : Form
    {


        public FMainPage()
        {
            InitializeComponent();
        }

        private void PicBoxUsuario_MouseClick(object sender, MouseEventArgs e)
        {
            FPerfilUsuario formUsu = new FPerfilUsuario(LoginInfo.IdUserLogged);
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

        private void BtnHeaderFB_Click(object sender, EventArgs e)
        {
            Process.Start("https://es-es.facebook.com/");
        }

        private void PnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnHeaderInsta_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/?hl=es");
        }

        private void BtnHeaderTwitter_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/");
        }

        private void BtnHeaderBuscarPeli_Click(object sender, EventArgs e)
        {
            FBusqueda form = new FBusqueda();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnHeaderInicio_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void BtnVerPerfil_Click(object sender, EventArgs e)
        {
            FPerfilUsuario form = new FPerfilUsuario(LoginInfo.IdUserLogged);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginInfo.CerrarSesion();

            FInicioSesion form = new FInicioSesion();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
