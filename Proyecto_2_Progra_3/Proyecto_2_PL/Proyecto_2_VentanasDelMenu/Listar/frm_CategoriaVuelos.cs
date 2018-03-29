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
    public partial class frm_CategoriaVuelos : Form
    {
        public frm_CategoriaVuelos()
        {
            InitializeComponent();
        }

        private void frm_CategoriaVuelos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            cls_T_CategoriasVuelos_BLL Obj_Clientes_BLL = new cls_T_CategoriasVuelos_BLL();
            string sMsjError = string.Empty;
            DataTable dtClientes = new DataTable();

            if (txtFiltro.Text == string.Empty)
            {
                dtClientes = Obj_Clientes_BLL.ListarCategoriasVuelos(ref sMsjError);

            }
            else
            {
                dtClientes = Obj_Clientes_BLL.FiltrarCategoriasAviones(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_CategoriasVuelos.DataSource = null;
                dgv_CategoriasVuelos.DataSource = dtClientes;
            }
            else
            {
                dgv_CategoriasVuelos.DataSource = null;
                MessageBox.Show("Se presentó un error : [ " + sMsjError + " ]. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cls_T_CategoriasVuelos_BLL objBLL = new cls_T_CategoriasVuelos_BLL();
            string sMsjError = string.Empty;

            if (dgv_CategoriasVuelos.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_CategoriaVuelos(ref sMsjError, dgv_CategoriasVuelos.SelectedRows[0].Cells[0].Value.ToString());

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
