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
using System.Windows.Forms;

namespace ProyectoEquipoVerde
{
    public partial class FCritica : Form
    {
        int idPeli;

        public FCritica(int idPeli)
        {
            InitializeComponent();

            this.idPeli = idPeli;
        }

        public FCritica(int idPeli, int idUsuario)
        {
            InitializeComponent();

            this.idPeli = idPeli;

            Critica critica = Critica.BuscarCritica(LoginInfo.IdUserLogged, idPeli);

            trbPuntuacion.Value = critica.Valoracion;
            lblNotaNum.Text = critica.Valoracion.ToString();
            trbTag.Value = critica.Tag1;
            pcbTag.Image = ImagenTag(critica.Tag1);
            txtCritica.Text = critica.Comentario;

            btnEnviar.Visible = false;
            btnModificar.Visible = true;
        }

        private Image ImagenTag(int numTag)
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

        private void TrbPuntuacion_Scroll(object sender, EventArgs e)
        {
            lblNotaNum.Text = trbPuntuacion.Value.ToString();
        }

        private void TrbTag_Scroll(object sender, EventArgs e)
        {
            pcbTag.Image = ImagenTag(trbTag.Value);
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Critica.HacerValoracion(idPeli, LoginInfo.IdUserLogged, trbPuntuacion.Value, trbTag.Value, txtCritica.Text);

            Close();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            Critica.ModificarValoracion(idPeli, LoginInfo.IdUserLogged, trbPuntuacion.Value, trbTag.Value, txtCritica.Text);

            Dispose();
        }



        private void AplicarIdioma()
        {
            lblNota.Text = Rec.lblNotaCritica;
            lblTag.Text = Rec.lblTagCritica;
            lblCritica.Text = Rec.lblCriticaCritica;
            btnEnviar.Text = Rec.btnEnviarCritica;
            btnModificar.Text = Rec.btnModificarCritica;
        }

        private void FCritica_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(LoginInfo.Cultura);
            AplicarIdioma();
        }
    }
}
