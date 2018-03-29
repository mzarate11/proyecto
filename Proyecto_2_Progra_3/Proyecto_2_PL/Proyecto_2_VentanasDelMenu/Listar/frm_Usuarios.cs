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
    public partial class frm_Usuarios : Form
    {
        public frm_Usuarios()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            cls_Usuarios_BLL objAviones_BLL = new cls_Usuarios_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            if (txtFiltro.Text == string.Empty)
            {
                DT = objAviones_BLL.ListarUsuarios(ref sMsjError);
            }
            else
            {
                DT = objAviones_BLL.FiltrarUsuarios(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Usuarios.DataSource = null;
                dgv_Usuarios.DataSource = DT;
            }
            else
            {
                dgv_Usuarios.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void MenuVentana_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dgv_Usuarios.DataSource = null;
            CargarDatos();
        }

        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_Usuarios_BLL objBLL = new cls_Usuarios_BLL();
            string sMsjError = string.Empty;

            if (dgv_Usuarios.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_Usuarios(ref sMsjError, dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString());

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
