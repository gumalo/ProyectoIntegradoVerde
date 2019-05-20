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
            FPerfilUsuario frm2 = new FPerfilUsuario(LoginInfo.IdUserLogged);
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            LoginInfo.CerrarSesion();

            FInicioSesion frm2 = new FInicioSesion();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }

        private void BtnHeaderInicio_Click(object sender, EventArgs e)
        {
            FMainPage frm2 = new FMainPage();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
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
            FBusqueda frm2 = new FBusqueda();
            frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
            frm2.Show();
            this.Hide();
        }

        private void DgvPeliculasUser_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPeliculasUser.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPeliculasUser.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvPeliculasUser.Rows[selectedrowindex];

                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                FPerfilPeli frm2 = new FPerfilPeli();
                frm2.FormClosed += new FormClosedEventHandler(frm2_FormClosed);
                frm2.Show();
                this.Hide();
            }
        }

        private void FPerfilUsuario_Load(object sender, EventArgs e)
        {

        }

        /*
        private void DgvCriticasUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvCriticasUser.Columns[e.ColumnIndex].Name == "tag")
            {
                if (e.Value.ToString() == "1")
                {
                    Bitmap tag1 = (Bitmap)Bitmap.FromFile(@"C:\Users\guill\Desktop\ProyectoIntegradoVerde-master\ProyectoEquipoVerde\ProyectoEquipoVerde\imagenes\grupo_w.png");

                    DataGridViewImageCell iCell = new DataGridViewImageCell();
                    iCell.Value = tag1;

                    e.Value = iCell;
                }
            }
        }
        */
    }
}
