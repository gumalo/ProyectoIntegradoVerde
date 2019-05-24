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
using System.Diagnostics;
using System.Windows.Forms;

namespace ProyectoEquipoVerde
{
    public partial class FPerfilPeli : Form
    {
        private Pelicula pelicula = new Pelicula();
        int idPeli;

        public FPerfilPeli(int idPeli)
        {
            InitializeComponent();

            this.idPeli = idPeli;

            pelicula = Pelicula.BuscarPelicula(idPeli);

            dgvCriticasPeli.DataSource = Pelicula.CargarCriticasPeli(idPeli);

            pcbPortada.Image = pelicula.Cartel;

            if (Pelicula.ObtenerValoracionMedia(idPeli) != -1)
                lblRating.Text = Pelicula.ObtenerValoracionMedia(idPeli).ToString();
            else
                lblRating.Text = "n/a";

            pcbTag.Image = ObtenerTagImagen(Pelicula.ObtenerTag(idPeli));
            lblTitulo.Text = pelicula.Nombre;
            lblDirector.Text = pelicula.Director;
            lblValorAnyo.Text = pelicula.Fecha.ToString("dd-MM-yyyy");
            txtDescr.Text = pelicula.Descripcion;
        }

        private Bitmap ObtenerTagImagen(int numtag)
        {
            switch (numtag)
            {
                case 1:
                    return new Bitmap(ProyectoEquipoVerde.Properties.Resources.brainwash);
                case 2:
                    return new Bitmap(ProyectoEquipoVerde.Properties.Resources.icons8_grupos_de_usuarios_100);
                case 3:
                    return new Bitmap(ProyectoEquipoVerde.Properties.Resources.icons8_boleto_100);
                case 4:
                    return new Bitmap(ProyectoEquipoVerde.Properties.Resources.icons8_hombres_lgbt_100);
                case 5:
                    return new Bitmap(ProyectoEquipoVerde.Properties.Resources.labyrinth);
                default:
                    return new Bitmap(ProyectoEquipoVerde.Properties.Resources.undefined_document_256);
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

        private void BtnCritica_Click(object sender, EventArgs e)
        {
            FCritica openForm;

            if (!Critica.ExisteCritica(LoginInfo.IdUserLogged, idPeli))
                openForm = new FCritica(idPeli);
            else
                openForm = new FCritica(idPeli, LoginInfo.IdUserLogged);

            openForm.Show();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FPerfilPeli form = new FPerfilPeli(idPeli);
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnHeaderBuscarPeli_Click(object sender, EventArgs e)
        {
            FBusqueda form = new FBusqueda();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
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

        private void DgvCriticasPeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCriticasPeli.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvCriticasPeli.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvCriticasPeli.Rows[selectedrowindex];

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


        private void AplicarIdioma()
        {
            lblTit.Text = Rec.lblTitPerfil;
            lblFecha.Text = Rec.lblFechaPerfil;
            lblDescripcion.Text = Rec.lblDescripcionPerfil;
            lblCriticaReciente.Text = Rec.lblCriticaRecientePerfil;
            lblTag.Text = Rec.lblTagPerfil;
            btnCritica.Text = Rec.btnCriticaPerfil;
            label1.Text = Rec.label1PerfilPeli;
        }

        private void FPerfilPeli_Load_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(LoginInfo.Cultura);
            AplicarIdioma();
        }
    }
}
