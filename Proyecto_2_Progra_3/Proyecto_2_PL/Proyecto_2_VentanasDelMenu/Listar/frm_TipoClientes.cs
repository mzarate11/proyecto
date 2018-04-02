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
    public partial class frm_TipoClientes : Form
    {
        #region GLOBAL
        cls_TiposClientes_DAL ObjTiposClientesDAL;
        #endregion

        public frm_TipoClientes()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {

            cls_TiposClientes_BLL Obj_Estados_BLL = new cls_TiposClientes_BLL();
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();

            if (txtFiltro.Text == string.Empty)
            {
                dtEstados = Obj_Estados_BLL.ListarTiposClientes(ref sMsjError);
            }
            else
            {
                dtEstados = Obj_Estados_BLL.FiltrarTiposClientes(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                Dgv_View.DataSource = null;
                Dgv_View.DataSource = dtEstados;

            }
            else
            {
                Dgv_View.DataSource = null;
                MessageBox.Show("Se Presentó un error : [ " + sMsjError + " ].", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            Dgv_View.DataSource = null;
            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Proyecto_2_PL.Proyecto_2_VentanaPrincipal.frm_Ventana_Principal V_Principal = new Proyecto_2_VentanaPrincipal.frm_Ventana_Principal();
            V_Principal.ShowDialog();
            this.Dispose();
        }

        private void frm_TipoClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_TiposClientes_BLL objBLL = new cls_TiposClientes_BLL();
            string sMsjError = string.Empty;

            if (Dgv_View.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_TipoCliente(ref sMsjError, Dgv_View.SelectedRows[0].Cells[0].Value.ToString());

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

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            ObjTiposClientesDAL = new cls_TiposClientes_DAL();
            frm_Modificar_TipoClientes PantTiposClientes = new frm_Modificar_TipoClientes();
            if (Dgv_View.RowCount > 0)
            {
                ObjTiposClientesDAL.CBandAX = 'U';
            ObjTiposClientesDAL.IIdTipoCliente = Convert.ToInt32(Dgv_View.SelectedRows[0].Cells[0].Value.ToString().Trim());
            ObjTiposClientesDAL.STipoCliente = Dgv_View.SelectedRows[0].Cells[1].Value.ToString().Trim();
            ObjTiposClientesDAL.SDescripcion = Dgv_View.SelectedRows[0].Cells[2].Value.ToString().Trim();
            ObjTiposClientesDAL.CIdEstado = Convert.ToChar(Dgv_View.SelectedRows[0].Cells[3].Value.ToString().Trim());

            PantTiposClientes.Obj_DAL_TiposClientes = ObjTiposClientesDAL;
            PantTiposClientes.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
            else {

                MessageBox.Show("No se pueden realizar la acción, debido a que no existen datos por modificar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
}

        private void bnt_Nuevo_Click(object sender, EventArgs e)
        {
                ObjTiposClientesDAL = new cls_TiposClientes_DAL();
            frm_Modificar_TipoClientes PantTiposClientes = new frm_Modificar_TipoClientes();
            
                ObjTiposClientesDAL.CBandAX = 'I';

                ObjTiposClientesDAL.IIdTipoCliente = 0;
                ObjTiposClientesDAL.SDescripcion = string.Empty;
                ObjTiposClientesDAL.STipoCliente = string.Empty;
                ObjTiposClientesDAL.CIdEstado = ' ';

                PantTiposClientes.Obj_DAL_TiposClientes = ObjTiposClientesDAL;
                PantTiposClientes.ShowDialog();


                txtFiltro.Text = string.Empty;
                CargarDatos();
            
        }

        private void Dgv_View_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ObjTiposClientesDAL = new cls_TiposClientes_DAL();
            frm_Modificar_TipoClientes PantTiposClientes = new frm_Modificar_TipoClientes();
            ObjTiposClientesDAL.CBandAX = 'U';
            ObjTiposClientesDAL.IIdTipoCliente = Convert.ToInt32(Dgv_View.SelectedRows[0].Cells[0].Value.ToString().Trim());
            ObjTiposClientesDAL.STipoCliente = Dgv_View.SelectedRows[0].Cells[1].Value.ToString().Trim();
            ObjTiposClientesDAL.SDescripcion = Dgv_View.SelectedRows[0].Cells[2].Value.ToString().Trim();
            ObjTiposClientesDAL.CIdEstado = Convert.ToChar(Dgv_View.SelectedRows[0].Cells[3].Value.ToString().Trim());

            PantTiposClientes.Obj_DAL_TiposClientes = ObjTiposClientesDAL;

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
    }
}
