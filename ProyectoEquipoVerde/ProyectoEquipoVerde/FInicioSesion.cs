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

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            LoginInfo.IniciarSesion(txtUsuario.Text);

            this.Hide();
            var form2 = new FMainPage();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form2 = new FRegistro();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}
