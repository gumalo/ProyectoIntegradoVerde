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
    public partial class FPerfilUsuario : Form
    {
        private Usuario usuario;

        public FPerfilUsuario(int idUsuario)
        {
            InitializeComponent();

            usuario = Usuario.BuscarUsuario(idUsuario);

            lblNick.Text = usuario.Nickname;
            lblNombre.Text = usuario.Nombre;
            ptcUsuario.Image = usuario.Imagen;

            dgvPeliculasUser.DataSource = Usuario.CargarPelisUsuario(idUsuario);
            dgvCriticasUser.DataSource = Usuario.CargarCriticasUsuario(idUsuario);

            if (idUsuario == LoginInfo.IdUserLogged)
                btnEditar.Visible = true;
        }

        private void BtnVerPerfil_Click(object sender, EventArgs e)
        {
            FPerfilUsuario form = new FPerfilUsuario(LoginInfo.IdUserLogged);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginInfo.CerrarSesion();

            FInicioSesion form = new FInicioSesion();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnHeaderInicio_Click(object sender, EventArgs e)
        {
            FMainPage form = new FMainPage();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
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

        private void BtnHeaderBuscarPeli_Click(object sender, EventArgs e)
        {
            FBusqueda form = new FBusqueda();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void DgvPeliculasUser_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPeliculasUser.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPeliculasUser.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvPeliculasUser.Rows[selectedrowindex];

                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                FPerfilPeli frm2 = new FPerfilPeli(id);
                frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                frm2.Show();
                this.Hide();
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FPerfilUsuario form = new FPerfilUsuario(usuario.Id);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FRegistro frm2 = new FRegistro(LoginInfo.IdUserLogged);
            frm2.Show();
        }

        private void DgvCriticasUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCriticasUser.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvCriticasUser.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvCriticasUser.Rows[selectedrowindex];

                int tag = Convert.ToInt32(selectedRow.Cells["tag"].Value);

                switch (tag)
                {
                    case 1:
                        pcbTagCrit.Image = ProyectoEquipoVerde.Properties.Resources.brainwash;
                        break;
                    case 2:
                        pcbTagCrit.Image = ProyectoEquipoVerde.Properties.Resources.icons8_grupos_de_usuarios_100;
                        break;
                    case 3:
                        pcbTagCrit.Image = ProyectoEquipoVerde.Properties.Resources.icons8_boleto_100;
                        break;
                    case 4:
                        pcbTagCrit.Image = ProyectoEquipoVerde.Properties.Resources.icons8_hombres_lgbt_100;
                        break;
                    case 5:
                        pcbTagCrit.Image = ProyectoEquipoVerde.Properties.Resources.labyrinth;
                        break;
                    default:
                        pcbTagCrit.Image = ProyectoEquipoVerde.Properties.Resources.undefined_document_256;
                        break;
                }
            }
        }
    }
}
