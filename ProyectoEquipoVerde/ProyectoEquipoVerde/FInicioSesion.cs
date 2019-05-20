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
    public partial class FInicioSesion : Form
    {
        public FInicioSesion()
        {
            InitializeComponent();
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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            LoginInfo.IniciarSesion(txtUsuario.Text);

            FMainPage frm2 = new FMainPage();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            FRegistro frm2 = new FRegistro();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }
    }
}
