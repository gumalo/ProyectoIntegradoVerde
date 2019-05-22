using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEquipoVerde
{
    public partial class FBusqueda : Form
    {
        public FBusqueda()
        {
            InitializeComponent();

            dgvUsuarios.DataSource = Usuario.CargarTodosUsuarios();

            dgvPelis.DataSource = Pelicula.CargarTodasPeliculas();

            //foreach (DataGridViewRow row in dgvPelis.Rows)
            //{
            //    row.Cells["tag"].Value = Pelicula.ObtenerTag(Convert.ToInt16(row.Cells["idpeli"].Value));

            //    //MessageBox.Show(Pelicula.ObtenerTag(Convert.ToInt16(row.Cells["idpeli"].Value)).ToString());
            //}

            for (int i = 0; i < dgvPelis.Columns.Count; i++)
                if (dgvPelis.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dgvPelis.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Stretch;
                    break;
                }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void DgvPeliculasUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvUsuarios.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvUsuarios.Rows[selectedrowindex];

                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                FPerfilUsuario form = new FPerfilUsuario(id);
                form.Show();
                form.FormClosing += (obj, args) => { this.Close(); };
                this.Hide();
            }
        }

        private void DgvPelis_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPelis.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPelis.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvPelis.Rows[selectedrowindex];

                int id = Convert.ToInt32(selectedRow.Cells["idpeli"].Value);

                FPerfilPeli form = new FPerfilPeli(id);
                form.Show();
                form.FormClosing += (obj, args) => { this.Close(); };
                this.Hide();
            }
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
            Refresh();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
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

        private void BtnBuscarUsuario_Click(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text == "") return;

            dgvUsuarios.DataSource = Usuario.BuscarUsuarios(txtBuscarUsuario.Text);
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvUsuarios.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvUsuarios.Rows[selectedrowindex];

                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                Usuario usuario = Usuario.BuscarUsuario(id);

                pcbUsuario.Image = usuario.Imagen;
            }
        }

        private void DgvPelis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPelis.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPelis.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvPelis.Rows[selectedrowindex];

                int id = Convert.ToInt32(selectedRow.Cells["idpeli"].Value);

                Pelicula pelicula = Pelicula.BuscarPelicula(id);

                pcbPortada.Image = pelicula.Cartel;

                int numTag = Pelicula.ObtenerTag(id);

                switch (numTag)
                {
                    case 1:
                        pcbTag.Image = ProyectoEquipoVerde.Properties.Resources.brainwash;
                        break;
                    case 2:
                        pcbTag.Image = ProyectoEquipoVerde.Properties.Resources.icons8_grupos_de_usuarios_100;
                        break;
                    case 3:
                        pcbTag.Image = ProyectoEquipoVerde.Properties.Resources.icons8_boleto_100;
                        break;
                    case 4:
                        pcbTag.Image = ProyectoEquipoVerde.Properties.Resources.icons8_hombres_lgbt_100;
                        break;
                    case 5:
                        pcbTag.Image = ProyectoEquipoVerde.Properties.Resources.labyrinth;
                        break;
                    default:
                        pcbTag.Image = ProyectoEquipoVerde.Properties.Resources.undefined_document_256;
                        break;
                }
            }
        }

        private void BtnPeli_Click(object sender, EventArgs e)
        {
            if (txtBuscarPeli.Text == "") return;

            dgvPelis.DataSource = Pelicula.BuscarPeliculas(txtBuscarPeli.Text);
        }

        private void TrbAnyo1_Scroll(object sender, EventArgs e)
        {
            lblAnyo1.Text = trbAnyo1.Value.ToString();
        }

        private void TrbAnyo2_Scroll(object sender, EventArgs e)
        {
            lblAnyo2.Text = trbAnyo2.Value.ToString();
        }

        private void BtnBuscarFecha_Click(object sender, EventArgs e)
        {
            if (trbAnyo1.Value < trbAnyo2.Value)
                dgvPelis.DataSource = Pelicula.BuscarPeliculasPorAnyo(trbAnyo1.Value, trbAnyo2.Value);
            else
                dgvPelis.DataSource = Pelicula.BuscarPeliculasPorAnyo(trbAnyo2.Value, trbAnyo1.Value);
        }
    }
}
