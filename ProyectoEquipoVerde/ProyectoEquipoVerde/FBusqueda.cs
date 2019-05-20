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
    public partial class FBusqueda : Form
    {
        public FBusqueda()
        {
            InitializeComponent();

            dgvBusqueda.DataSource = Usuario.CargarTodosUsuarios();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void DgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBusqueda.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvBusqueda.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvBusqueda.Rows[selectedrowindex];

                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                FPerfilUsuario frm2 = new FPerfilUsuario(id);
                frm2.Show();
            }
        }

        private void frm2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
