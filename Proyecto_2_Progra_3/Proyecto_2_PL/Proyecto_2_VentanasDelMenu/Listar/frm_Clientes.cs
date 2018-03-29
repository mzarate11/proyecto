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
    public partial class frm_Clientes : Form
    {
        public frm_Clientes()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            cls_Clientes_BLL Obj_Clientes_BLL = new cls_Clientes_BLL();
            string sMsjError = string.Empty;
            DataTable dtClientes = new DataTable();

            if (txtFiltro.Text == string.Empty)
            {
                dtClientes = Obj_Clientes_BLL.Listar_Clientes(ref sMsjError);

            }
            else
            {
                dtClientes = Obj_Clientes_BLL.Filtrar_Clientes(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Clientes.DataSource = null;
                dgv_Clientes.DataSource = dtClientes;
            }
            else
            {
                dgv_Clientes.DataSource = null;
                MessageBox.Show("Se presentó un error : [ " + sMsjError + " ]. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            dgv_Clientes.DataSource = null;
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
            cls_Clientes_BLL objBLL = new cls_Clientes_BLL();
            string sMsjError = string.Empty;

            if (dgv_Clientes.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_Clientes(ref sMsjError, dgv_Clientes.SelectedRows[0].Cells[0].Value.ToString());

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
