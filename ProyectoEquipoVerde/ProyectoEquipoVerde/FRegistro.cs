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

        public FRegistro(string editar)
        {
            InitializeComponent();

            Usuario usuario = Usuario.BuscarUsuario(LoginInfo.IdUserLogged);

            txtUsuario.Text = usuario.Nickname;
            txtNombre.Text = usuario.Nombre;
            txtContrasenya.Text = usuario.Contrasenya;
            pcbImagenPerfil.Image = usuario.Imagen;


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
            if (Usuario.ExisteUsuario(txtUsuario.Text) == true)
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

            if (txtRepContrasenya.Text != txtContrasenya.Text)
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

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void ChbContr_CheckedChanged(object sender, EventArgs e)
        {
            if (chbContr.Checked == false)
            {
                txtContrasenya.UseSystemPasswordChar = true;
                txtRepContrasenya.UseSystemPasswordChar = true;
            }
            else
            {
                txtContrasenya.UseSystemPasswordChar = false;
                txtRepContrasenya.UseSystemPasswordChar = false;
            }
        }

        private void btnCargarImagen_Click_1(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                imagen = new Bitmap(open.FileName);
                pcbImagenPerfil.Image = imagen;
            }
        }

        private void btnRegistrarse_Click_1(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            Usuario usuario = new Usuario(txtNombre.Text, txtUsuario.Text, txtContrasenya.Text, imagen);

            Usuario.AgregarUsuario(usuario);

            LoginInfo.IniciarSesion(usuario.Nickname);

            FMainPage frm2 = new FMainPage();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }
    }
}