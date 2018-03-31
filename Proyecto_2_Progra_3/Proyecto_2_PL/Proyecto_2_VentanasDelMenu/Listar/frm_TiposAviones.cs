using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;
using Proyecto_2_BLL.Catagolos_Mantinimiento_BLL;
using Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu
{
    public partial class frm_TiposAviones : Form
    {
        cls_TipoAviones_DAL Obj_Mant_DAL;

        public frm_TiposAviones()
        {
            InitializeComponent();
        }

        private void CargarDatosEstados()
        {
            cls_TiposA_BLL Obj_BLL = new cls_TiposA_BLL();
            string sMsgError = string.Empty;
            DataTable DT_Estados = new DataTable();

            if (txtFiltro.Text == string.Empty)
            {
                DT_Estados = Obj_BLL.ListarTiposA(ref sMsgError);
            }
            else
            {
                DT_Estados = Obj_BLL.FiltrarTiposA(ref sMsgError, txtFiltro.Text.Trim());
            }

            if (sMsgError == string.Empty)
            {
                dgv_TiposA.DataSource = null;
                dgv_TiposA.DataSource = DT_Estados;
            }
            else
            {
                dgv_TiposA.DataSource = null;
                MessageBox.Show("Se ha generado el error: " + sMsgError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_TiposAviones_Load(object sender, EventArgs e)
        {
            CargarDatosEstados();
            txtFiltro.SelectAll();
            txtFiltro.Focus();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarDatosEstados();
        }

        private void txtFiltro_TextChanged_1(object sender, EventArgs e)
        {
            CargarDatosEstados();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_TiposA_BLL objBLL = new cls_TiposA_BLL();
            string sMsjError = string.Empty;

            if (dgv_TiposA.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_TiposAviones(ref sMsjError, dgv_TiposA.SelectedRows[0].Cells[0].Value.ToString());

                    if (sMsjError != string.Empty)
                    {
                        MessageBox.Show("Se presento un error a la hora de listar : [ " + sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarDatosEstados();
                    }
                    txtFiltro.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar");
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Obj_Mant_DAL = new cls_TipoAviones_DAL();
            Obj_Mant_DAL.cbanderaAccion = 'U';
            Obj_Mant_DAL.sIdTipoAvion = dgv_TiposA.SelectedRows[0].Cells[0].Value.ToString().Trim();
            Obj_Mant_DAL.sNombreTipoAvion = dgv_TiposA.SelectedRows[0].Cells[1].Value.ToString().Trim();
            Obj_Mant_DAL.sDescTipoAvion = dgv_TiposA.SelectedRows[0].Cells[2].Value.ToString().Trim();
            Obj_Mant_DAL.iCapacidadPasajeros = Convert.ToInt16(dgv_TiposA.SelectedRows[0].Cells[3].Value.ToString().Trim());
            Obj_Mant_DAL.dcapacidadPeso = Convert.ToDouble(dgv_TiposA.SelectedRows[0].Cells[4].Value.ToString().Trim());

            frm_ModificarNuevo_TipoAvion V_Modificar = new frm_ModificarNuevo_TipoAvion();
            this.Hide();
            V_Modificar.Obj_Mant_DAL = Obj_Mant_DAL; // pasamos en objeto dal a la otra pantalla
            V_Modificar.ShowDialog();
            this.Show();
            CargarDatosEstados();
        }

        private void bnt_Nuevo_Click(object sender, EventArgs e)
        {
            Obj_Mant_DAL = new cls_TipoAviones_DAL();
            Obj_Mant_DAL.cbanderaAccion = 'I';
            this.Hide();
            frm_ModificarNuevo_TipoAvion V_Modificar = new frm_ModificarNuevo_TipoAvion();
            V_Modificar.Obj_Mant_DAL = Obj_Mant_DAL; // pasamos en objeto dal a la otra pantalla
            V_Modificar.ShowDialog();
            this.Show();
            CargarDatosEstados();
        }
    }
}
