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
    public partial class frm_TipoEmpleados : Form
    {
        #region
        cls_TipoEmpleados_DAL ObjTipoEmpleadosDAL;
        #endregion
        public frm_TipoEmpleados()
        {
            InitializeComponent();
        }
        private void CargarDatos()
        {

            cls_TiposEmpleados_BLL Obj_Tipos_Empleados__BLL = new cls_TiposEmpleados_BLL();
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();

            if (txtFiltro.Text == string.Empty)
            {
                dtEstados = Obj_Tipos_Empleados__BLL.ListarTiposEmpleados(ref sMsjError);
            }
            else
            {
                dtEstados = Obj_Tipos_Empleados__BLL.FiltrarTiposEmpleados(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_view.DataSource = null;
                dgv_view.DataSource = dtEstados;

            }
            else
            {
                dgv_view.DataSource = null;
                MessageBox.Show("Se Presentó un error : [ " + sMsjError + " ].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            dgv_view.DataSource = null;
            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Proyecto_2_PL.Proyecto_2_VentanaPrincipal.frm_Ventana_Principal V_Principal = new Proyecto_2_VentanaPrincipal.frm_Ventana_Principal();
            V_Principal.ShowDialog();
            this.Dispose();
        }

        private void frm_TipoEmpleados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_TiposEmpleados_BLL objBLL = new cls_TiposEmpleados_BLL();
            string sMsjError = string.Empty;

            if (dgv_view.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_TipoEmpleado(ref sMsjError, dgv_view.SelectedRows[0].Cells[0].Value.ToString());

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

        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void bnt_Nuevo_Click(object sender, EventArgs e)
        {
            ObjTipoEmpleadosDAL = new cls_TipoEmpleados_DAL();
            frm_Modificar_TipoEmpleado PantTipoEmpleado = new frm_Modificar_TipoEmpleado();
            ObjTipoEmpleadosDAL.CBandAX = 'I';

            PantTipoEmpleado.Obj_DAL_TipoEmpleado = ObjTipoEmpleadosDAL;
            Hide();
            PantTipoEmpleado.ShowDialog();
            Show();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            ObjTipoEmpleadosDAL = new cls_TipoEmpleados_DAL();
            frm_Modificar_TipoEmpleado PantTipoEmpleado = new frm_Modificar_TipoEmpleado();

            if (dgv_view.RowCount > 0)
            {
                ObjTipoEmpleadosDAL.CBandAX = 'U';
                ObjTipoEmpleadosDAL.ITipoEmpleado = Convert.ToInt32(dgv_view.SelectedRows[0].Cells[0].Value.ToString().Trim());
                ObjTipoEmpleadosDAL.SDescTipo = dgv_view.SelectedRows[0].Cells[1].Value.ToString().Trim();
                ObjTipoEmpleadosDAL.CIdEstado = Convert.ToChar(dgv_view.SelectedRows[0].Cells[2].Value.ToString().Trim());

                PantTipoEmpleado.Obj_DAL_TipoEmpleado = ObjTipoEmpleadosDAL;

                Hide();
                PantTipoEmpleado.ShowDialog();
                Show();

                txtFiltro.Text = string.Empty;
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pueden realizar la acción, debido a que no existen datos por modificar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_view_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjTipoEmpleadosDAL = new cls_TipoEmpleados_DAL();
            frm_Modificar_TipoEmpleado PantTipoEmpleado = new frm_Modificar_TipoEmpleado();
            ObjTipoEmpleadosDAL.CBandAX = 'U';
            ObjTipoEmpleadosDAL.ITipoEmpleado = Convert.ToInt32(dgv_view.SelectedRows[0].Cells[0].Value.ToString().Trim());
            ObjTipoEmpleadosDAL.SDescTipo = dgv_view.SelectedRows[0].Cells[1].Value.ToString().Trim();
            ObjTipoEmpleadosDAL.CIdEstado = Convert.ToChar(dgv_view.SelectedRows[0].Cells[2].Value.ToString().Trim());

            PantTipoEmpleado.Obj_DAL_TipoEmpleado = ObjTipoEmpleadosDAL;
            Hide();
            PantTipoEmpleado.ShowDialog();
            Show();
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
    }
}
