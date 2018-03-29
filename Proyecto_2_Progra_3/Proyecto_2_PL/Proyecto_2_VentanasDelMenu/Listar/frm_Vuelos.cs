using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_2_BLL.Catagolos_Mantinimiento_BLL;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu
{
    public partial class frm_Vuelos : Form
    {
        public frm_Vuelos()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            cls_Vuelos_BLL objAviones_BLL = new cls_Vuelos_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            if (txtFiltro.Text == string.Empty)
            {
                DT = objAviones_BLL.ListarVuelos(ref sMsjError);
            }
            else
            {
                DT = objAviones_BLL.FiltrarVuelos(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Vuelos.DataSource = null;
                dgv_Vuelos.DataSource = DT;
            }
            else
            {
                dgv_Vuelos.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frm_Vuelos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            dgv_Vuelos = null;
            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_Vuelos_BLL objBLL = new cls_Vuelos_BLL();
            string sMsjError = string.Empty;

            if (dgv_Vuelos.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_Vuelos(ref sMsjError, dgv_Vuelos.SelectedRows[0].Cells[0].Value.ToString());

                    if (sMsjError != string.Empty)
                    {
                        MessageBox.Show("Se presento un error a la hora de listar : [ " + sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    txtFiltro.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar");
            }
        }
    }
}
