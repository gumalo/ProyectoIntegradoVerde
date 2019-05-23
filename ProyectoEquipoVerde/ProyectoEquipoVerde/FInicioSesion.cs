using System;
using System.Globalization;
using System.Threading;
using ProyectoEquipoVerde.Recursos;
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
    public partial class FInicioSesion : Form
    {
        public FInicioSesion()
        {
            InitializeComponent();
        }

        public FInicioSesion(string nickname)
        {
            InitializeComponent();

            txtUsuario.Text = nickname;
        }

        private void AplicarIdioma()
        {
            lblContrasenya.Text = Rec.lblContrasenyaInicio;
            lblUsuario.Text = Rec.lblUsuarioInicio;
            btnInicioSesion.Text = Rec.btnInicioSesionInicio;
            btnRegistrarse.Text = Rec.btnRegistrarseInicio;
        }


        private bool ValidarDatos()
        {
            bool ok = true;

            if (txtUsuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, "Ingresa un nombre de usuario");
            }
            else
                errorProvider1.Clear();

            if (txtContrasenya.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtContrasenya, "Ingresa una contraseña");
            }
            else
                errorProvider1.Clear();

            if (!Usuario.ExisteUsuario(txtUsuario.Text, txtContrasenya.Text))
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, "Usuario o contraseña incorrectos");
            }
            else
                errorProvider1.Clear();

            return ok;
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            LoginInfo.IniciarSesion(txtUsuario.Text);

            FMainPage form = new FMainPage();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FRegistro form = new FRegistro();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnEspanyol_Click_1(object sender, EventArgs e)
        {
            LoginInfo.Cultura = "ES-ES";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(LoginInfo.Cultura);
            AplicarIdioma();
        }

        private void BtnIngles_Click(object sender, EventArgs e)
        {
            LoginInfo.Cultura = "EN-GB";
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(LoginInfo.Cultura);
            AplicarIdioma();
        }

        private void FInicioSesion_Load(object sender, EventArgs e)
        {
            LoginInfo.Cultura = "ES-ES";
        }
    }
}
