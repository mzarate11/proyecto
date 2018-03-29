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
using Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu
{
    public partial class frm_Estados : Form
    {
        #region Global
        cls_Estados_DAL ObjEstadosDAL;
        #endregion
        public frm_Estados()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {

            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();

            if (txtFiltro.Text == string.Empty)
            {
                dtEstados = Obj_Estados_BLL.Listar_Estados(ref sMsjError);
            }
            else
            {
                dtEstados = Obj_Estados_BLL.Filtrar_Estados(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Estados.DataSource = null;
                dgv_Estados.DataSource = dtEstados;

            }
            else
            {
                dgv_Estados.DataSource = null;
                MessageBox.Show("Se Presentó un error : [ " + sMsjError + " ].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frm_Estados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            dgv_Estados.DataSource = null;
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
            cls_Estados_BLL objBLL = new cls_Estados_BLL();
            string sMsjError = string.Empty;

            if(dgv_Estados.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_Estados(ref sMsjError, dgv_Estados.SelectedRows[0].Cells[0].Value.ToString());

                    if(sMsjError != string.Empty)
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

        private void bnt_Nuevo_Click(object sender, EventArgs e)
        {
            ObjEstadosDAL = new cls_Estados_DAL();
            frm_Mostrar_Estados PantEstados = new frm_Mostrar_Estados();
            ObjEstadosDAL.cBandAX = 'I';
            PantEstados.Obj_DAL_Estados = ObjEstadosDAL;
            PantEstados.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            ObjEstadosDAL = new cls_Estados_DAL();
            frm_Mostrar_Estados PantEstados = new frm_Mostrar_Estados();
            ObjEstadosDAL.cBandAX = 'U';
            ObjEstadosDAL.cIdEstado = Convert.ToChar(dgv_Estados.SelectedRows[0].Cells[0].Value.ToString().Trim());
            ObjEstadosDAL.sDescripcion = dgv_Estados.SelectedRows[0].Cells[1].Value.ToString().Trim();
            PantEstados.Obj_DAL_Estados = ObjEstadosDAL;
            PantEstados.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void dgv_Estados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjEstadosDAL = new cls_Estados_DAL();
            frm_Mostrar_Estados PantEstados = new frm_Mostrar_Estados();
            ObjEstadosDAL.cBandAX = 'U';
            ObjEstadosDAL.cIdEstado = Convert.ToChar(dgv_Estados.SelectedRows[0].Cells[0].Value.ToString().Trim());
            ObjEstadosDAL.sDescripcion = dgv_Estados.SelectedRows[0].Cells[1].Value.ToString().Trim();
            PantEstados.Obj_DAL_Estados = ObjEstadosDAL;
            PantEstados.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
    }
}
