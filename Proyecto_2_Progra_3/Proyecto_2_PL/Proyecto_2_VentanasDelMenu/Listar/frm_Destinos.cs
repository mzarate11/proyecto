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
    public partial class frm_Destinos : Form
    {
        public frm_Destinos()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {

            cls_Destinos_BLL Obj_Estados_BLL = new cls_Destinos_BLL();
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();

            if (tls_txt_Filtro.Text == string.Empty)
            {
                dtEstados = Obj_Estados_BLL.ListarDestinos(ref sMsjError);
            }
            else
            {
                dtEstados = Obj_Estados_BLL.FiltrarDestinos(ref sMsjError, tls_txt_Filtro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
               dgv_Destinos.DataSource = null;
                dgv_Destinos.DataSource = dtEstados;

            }
            else
            {
                dgv_Destinos.DataSource = null;
                MessageBox.Show("Se Presentó un error : [ " + sMsjError + " ].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_Destinos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tls_btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tls_btn_Refrescar_Click(object sender, EventArgs e)
        {
            dgv_Destinos = null;
            CargarDatos();
        }

        private void tls_btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_Destinos_BLL objBLL = new cls_Destinos_BLL();
            string sMsjError = string.Empty;

            if (dgv_Destinos.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_Destinos(ref sMsjError, dgv_Destinos.SelectedRows[0].Cells[0].Value.ToString());

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
