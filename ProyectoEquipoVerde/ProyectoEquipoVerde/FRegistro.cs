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
        public FRegistro()
        {
            InitializeComponent();
        }

        public FRegistro(int iduser)
        {
            InitializeComponent();

            Usuario usuario = Usuario.BuscarUsuario(LoginInfo.IdUserLogged);

            txtUsuario.Text = usuario.Nickname;
            txtNombre.Text = usuario.Nombre;
            txtContrasenya.Text = usuario.Contrasenya;
            pcbImagenPerfil.Image = usuario.Imagen;

            btnRegistrarse.Visible = false;
            btnModificar.Visible = true;
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
                pcbImagenPerfil.Image = new Bitmap(open.FileName);
            }
        }

        private void btnRegistrarse_Click_1(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            if (Usuario.ExisteUsuario(txtUsuario.Text))
            {
                var result = MessageBox.Show("¿Quieres iniciar sesión con ese usuario?", "Usuario ya registrado", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    FInicioSesion form2 = new FInicioSesion(txtUsuario.Text);
                    form2.Show();
                    form2.FormClosing += (obj, args) => { this.Close(); };
                    this.Hide();
                }

                return;
            }

            Usuario usuario = new Usuario(txtNombre.Text, txtUsuario.Text, txtContrasenya.Text, pcbImagenPerfil.Image);

            Usuario.AgregarUsuario(usuario);

            LoginInfo.IniciarSesion(usuario.Nickname);

            FMainPage form = new FMainPage();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Usuario.ModificarUsuario(LoginInfo.IdUserLogged, txtNombre.Text, txtUsuario.Text, txtContrasenya.Text, pcbImagenPerfil.Image);

            Dispose();
        }
    }
}