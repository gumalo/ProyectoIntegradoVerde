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
    public partial class FCritica : Form
    {
        int idPeli;

        public FCritica(int idPeli)
        {
            InitializeComponent();

            this.idPeli = idPeli;
        }

        private void TrbPuntuacion_Scroll(object sender, EventArgs e)
        {
            lblNotaNum.Text = trbPuntuacion.Value.ToString();
        }

        private void TrbTag_Scroll(object sender, EventArgs e)
        {
            switch (trbTag.Value)
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

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            Critica.HacerValoracion(idPeli, LoginInfo.IdUserLogged, trbPuntuacion.Value, trbTag.Value, txtCritica.Text);

            Close();
        }
    }
}
