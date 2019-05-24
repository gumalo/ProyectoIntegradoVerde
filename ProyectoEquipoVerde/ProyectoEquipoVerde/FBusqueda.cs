using System;
using System.Globalization;
using System.Threading;
using ProyectoEquipoVerde.Recursos;
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

        private void FBusqueda_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(LoginInfo.Cultura);
            AplicarIdioma();
        }


        private void AplicarIdioma()
        {
            lblUsuarios.Text = Rec.lblUsuariosBusqueda;
            lblPelis.Text = Rec.lblPelisBusqueda;
            lblImagenPerfil.Text = Rec.lblImagenPerfil;
            lblPortada.Text = Rec.lblPortadaBusqueda;
            lblTag.Text = Rec.lblTagBusqueda;
            btnBuscarFecha.Text = Rec.btnBuscarFechaBusqueda;
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
            FBusqueda form = new FBusqueda();
            form.Show();
            form.FormClosing += (obj, args) => { this.Close(); };
            this.Hide();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
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

                pcbTag.Image = ImagenTag(numTag);
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
            HacerVisiblesFilas();

            //if (trbAnyo1.Value < trbAnyo2.Value)
            //    dgvPelis.DataSource = Pelicula.BuscarPeliculasPorAnyo(trbAnyo1.Value, trbAnyo2.Value);
            //else
            //    dgvPelis.DataSource = Pelicula.BuscarPeliculasPorAnyo(trbAnyo2.Value, trbAnyo1.Value);

            string stFecha1 = $"{trbAnyo1.Value}/01/01";
            DateTime fecha1 = Convert.ToDateTime(stFecha1);

            string stFecha2 = $"{trbAnyo2.Value}/01/01";
            DateTime fecha2 = Convert.ToDateTime(stFecha2);

            DateTime fechaFila;

            if (trbAnyo1.Value < trbAnyo2.Value)
            {
                foreach (DataGridViewRow row in dgvPelis.Rows)
                {
                    fechaFila = Convert.ToDateTime(row.Cells["fecha"].Value);

                    if (fechaFila.Ticks < fecha1.Ticks || fechaFila.Ticks > fecha2.Ticks)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvPelis.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvPelis.Rows)
                {
                    fechaFila = Convert.ToDateTime(row.Cells["fecha"].Value);

                    if (fechaFila.Ticks > fecha1.Ticks || fechaFila.Ticks < fecha2.Ticks)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvPelis.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                }
            }
        }

        public static Image ImagenTag(int numTag)
        {
            Image imagenTag;

            switch (numTag)
            {
                case 1:
                    imagenTag = ProyectoEquipoVerde.Properties.Resources.brainwash;
                    break;
                case 2:
                    imagenTag = ProyectoEquipoVerde.Properties.Resources.icons8_grupos_de_usuarios_100;
                    break;
                case 3:
                    imagenTag = ProyectoEquipoVerde.Properties.Resources.icons8_boleto_100;
                    break;
                case 4:
                    imagenTag = ProyectoEquipoVerde.Properties.Resources.icons8_hombres_lgbt_100;
                    break;
                case 5:
                    imagenTag = ProyectoEquipoVerde.Properties.Resources.labyrinth;
                    break;
                default:
                    imagenTag = ProyectoEquipoVerde.Properties.Resources.undefined_document_256;
                    break;
            }

            return imagenTag;
        }

        private void TrbTag_Scroll(object sender, EventArgs e)
        {
            pcbTagBusqueda.Image = ImagenTag(trbTag.Value);
        }

        private void BtnBuscarTag_Click(object sender, EventArgs e)
        {
            HacerVisiblesFilas();

            foreach (DataGridViewRow row in dgvPelis.Rows)
            {
                if (row.Cells["punt_media"].Value != null)
                {
                    if (Pelicula.ObtenerTag((int)row.Cells["idpeli"].Value) != trbTag.Value)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dgvPelis.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                }
            }
        }

        private void HacerVisiblesFilas()
        {
            foreach (DataGridViewColumn column in dgvPelis.Columns)
            {
                if (column.Name != "idpeli")
                    column.Visible = true;
            }
        }

        private void FBusqueda_Load_1(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(LoginInfo.Cultura);
            AplicarIdioma();
        }
    }
}
