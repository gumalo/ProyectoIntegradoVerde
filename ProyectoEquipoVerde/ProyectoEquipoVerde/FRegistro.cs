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
    public partial class FRegistro : Form
    {
        Bitmap imagen;

        public FRegistro()
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

            /*
            if (Usuario.ExisteUsuario(txtUsuario.Text))
            {
                ok = false;
                errorProvider1.SetError(txtUsuario, "El usuario ya existe");
            }
            else
                errorProvider1.Clear();
            */

            if (txtNombre.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtNombre, "Ingresa un nombre");
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

            if (txtRepContrasenya.Text == txtContrasenya.Text)
            {
                ok = false;
                errorProvider1.SetError(txtRepContrasenya, "No coinciden los campos");
            }
            else
                errorProvider1.Clear();

            if (imagen == null)
            {
                ok = false;
                errorProvider1.SetError(pcbImagenPerfil, "No se ha añadido una imagen");
            }
            else
                errorProvider1.Clear();

            return ok;
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagen = new Bitmap(open.FileName);
                pcbImagenPerfil.Image = imagen;
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            var usuario = new Usuario(txtNombre.Text, txtUsuario.Text, txtContrasenya.Text, imagen);

            if (Usuario.AgregarUsuario(usuario) == -1)
            {
                MessageBox.Show("El registro ha fallado");
                return;
            }

            LoginInfo.IniciarSesion(usuario.Nickname);

            this.Hide();
            var form2 = new FMainPage();
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }
    }
}