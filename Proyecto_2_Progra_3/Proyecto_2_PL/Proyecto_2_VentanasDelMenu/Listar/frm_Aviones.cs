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
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;
using Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu
{
    public partial class frm_Aviones : Form
    {
        cls_Aviones_DAL objDal_Aviones = new cls_Aviones_DAL();
        public frm_Aviones()
        {
            InitializeComponent();
        }

        private void frm_Aviones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            cls_Aviones_BLL objAviones_BLL = new cls_Aviones_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            if (txtFiltro.Text == string.Empty)
            {
                DT = objAviones_BLL.ListarAvion(ref sMsjError);
            }
            else
            {
                DT = objAviones_BLL.FiltrarAerolineas(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Aviones.DataSource = null;
                dgv_Aviones.DataSource = DT;
            }
            else
            {
                dgv_Aviones.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_Aviones_BLL objBLL = new cls_Aviones_BLL();
            string sMsjError = string.Empty;

            if (dgv_Aviones.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_Aviones(ref sMsjError, dgv_Aviones.SelectedRows[0].Cells[0].Value.ToString());

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

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if(dgv_Aviones.RowCount == 0)
            {
                MessageBox.Show("No existen datos para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                objDal_Aviones = new cls_Aviones_DAL();
                objDal_Aviones.cBandera = 'U';
                objDal_Aviones.sIdAvion = dgv_Aviones.SelectedRows[0].Cells[0].Value.ToString().Trim();
                objDal_Aviones.sNomAvion = dgv_Aviones.SelectedRows[0].Cells[1].Value.ToString().Trim();
                objDal_Aviones.sDescAvion = dgv_Aviones.SelectedRows[0].Cells[2].Value.ToString().Trim();
                objDal_Aviones.iIdAerolinea = Convert.ToInt32(dgv_Aviones.SelectedRows[0].Cells[3].Value.ToString().Trim());
                objDal_Aviones.sIdTipoAvion = dgv_Aviones.SelectedRows[0].Cells[4].Value.ToString().Trim();
                objDal_Aviones.cIdEstado = Convert.ToChar(dgv_Aviones.SelectedRows[0].Cells[5].Value.ToString().Trim());
                frm_ModificarAviones Pantalla = new frm_ModificarAviones();
                Pantalla.objDal_Aviones = objDal_Aviones;
                Hide();
                Pantalla.ShowDialog();
                Show();
                txtFiltro.Text = string.Empty;
                CargarDatos();
            }            
        }

        private void bnt_Nuevo_Click(object sender, EventArgs e)
        {
            frm_ModificarAviones Pantalla = new frm_ModificarAviones();
            objDal_Aviones = new cls_Aviones_DAL();
            objDal_Aviones.cBandera = 'I';
            Pantalla.objDal_Aviones = objDal_Aviones;
            Hide();
            Pantalla.ShowDialog();
            Show();
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void dgv_Aviones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objDal_Aviones = new cls_Aviones_DAL();
            objDal_Aviones.cBandera = 'U';
            objDal_Aviones.sIdAvion = dgv_Aviones.SelectedRows[0].Cells[0].Value.ToString().Trim();
            objDal_Aviones.sNomAvion = dgv_Aviones.SelectedRows[0].Cells[1].Value.ToString().Trim();
            objDal_Aviones.sDescAvion = dgv_Aviones.SelectedRows[0].Cells[2].Value.ToString().Trim();
            objDal_Aviones.iIdAerolinea = Convert.ToInt32(dgv_Aviones.SelectedRows[0].Cells[3].Value.ToString().Trim());
            objDal_Aviones.sIdTipoAvion = dgv_Aviones.SelectedRows[0].Cells[4].Value.ToString().Trim();
            objDal_Aviones.cIdEstado = Convert.ToChar(dgv_Aviones.SelectedRows[0].Cells[5].Value.ToString().Trim());
            frm_ModificarAviones Pantalla = new frm_ModificarAviones();
            Pantalla.objDal_Aviones = objDal_Aviones;
            Hide();
            Pantalla.ShowDialog();
            Show();
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
    }
}
