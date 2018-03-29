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
    public partial class frm_Paises : Form
    {
        public frm_Paises()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {

            cls_Paises_BLL Obj_Estados_BLL = new cls_Paises_BLL();
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();

            if (tls_txt_Filtro.Text == string.Empty)
            {
                dtEstados = Obj_Estados_BLL.ListarPaises(ref sMsjError);
            }
            else
            {
                dtEstados = Obj_Estados_BLL.FiltrarPaises(ref sMsjError, tls_txt_Filtro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Paises.DataSource = null;
                dgv_Paises.DataSource = dtEstados;

            }
            else
            {
                dgv_Paises.DataSource = null;
                MessageBox.Show("Se Presentó un error : [ " + sMsjError + " ].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuVentana_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frm_Paises_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tls_btn_Refrescar_Click(object sender, EventArgs e)
        {
            dgv_Paises = null;
            CargarDatos();
        }

        private void tls_btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tls_txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tls_btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_Paises_BLL objBLL = new cls_Paises_BLL();
            string sMsjError = string.Empty;

            if (dgv_Paises.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_Paises(ref sMsjError, dgv_Paises.SelectedRows[0].Cells[0].Value.ToString());

                    if (sMsjError != string.Empty)
                    {
                        MessageBox.Show("Se presento un error a la hora de listar : [ " + sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatos();
                    }
                    tls_txt_Filtro.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar");
            }
        }
    }
}
