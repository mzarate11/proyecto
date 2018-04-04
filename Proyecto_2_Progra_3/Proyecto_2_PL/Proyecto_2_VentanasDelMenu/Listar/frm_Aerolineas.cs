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
    public partial class frm_Aerolineas : Form
    {
        cls_Aerolineas_DAL objDal_Aerolinea = new cls_Aerolineas_DAL();

        public frm_Aerolineas()
        {
            InitializeComponent();
        }

        private void frm_Aerolineas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
        private void CargarDatos()
        {
            cls_Aerolineas_BLL objAerolineas_BLL = new cls_Aerolineas_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            if (txtFiltro.Text == string.Empty)
            {
                DT = objAerolineas_BLL.ListarAerolineas(ref sMsjError);
            }
            else
            {
                DT = objAerolineas_BLL.FiltrarAerolineas(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Aerolineas.DataSource = null;
                dgv_Aerolineas.DataSource = DT;
            }
            else
            {
                dgv_Aerolineas.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_Aerolineas_BLL objBLL = new cls_Aerolineas_BLL();
            string sMsjError = string.Empty;

            if (dgv_Aerolineas.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_Aerolineas(ref sMsjError, dgv_Aerolineas.SelectedRows[0].Cells[0].Value.ToString());

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
            if(dgv_Aerolineas.RowCount == 0)
            {
                MessageBox.Show("No existen datos para modificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                objDal_Aerolinea = new cls_Aerolineas_DAL();
                objDal_Aerolinea.cBandera = 'U';
                objDal_Aerolinea.iIdAerolinea = Convert.ToInt32(dgv_Aerolineas.SelectedRows[0].Cells[0].Value.ToString().Trim());
                objDal_Aerolinea.sNombreAerolinea = dgv_Aerolineas.SelectedRows[0].Cells[1].Value.ToString().Trim();
                objDal_Aerolinea.cIdEstado = Convert.ToChar(dgv_Aerolineas.SelectedRows[0].Cells[3].Value.ToString().Trim());
                frm_ModificarAerolineas Pantalla = new frm_ModificarAerolineas();
                Pantalla.ShowDialog();

                txtFiltro.Text = string.Empty;
                CargarDatos();
            }            
        }

        private void bnt_Nuevo_Click(object sender, EventArgs e)
        {
            frm_ModificarAerolineas Pantalla = new frm_ModificarAerolineas();
            objDal_Aerolinea = new cls_Aerolineas_DAL();
            objDal_Aerolinea.cBandera = 'I';
            Pantalla.objDAL_Aerolinea = objDal_Aerolinea;
            Hide();
            Pantalla.ShowDialog();
            Show();
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }

        private void dgv_Aerolineas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            objDal_Aerolinea = new cls_Aerolineas_DAL();
            objDal_Aerolinea.cBandera = 'U';
            objDal_Aerolinea.iIdAerolinea = Convert.ToInt32(dgv_Aerolineas.SelectedRows[0].Cells[0].Value.ToString().Trim());
            objDal_Aerolinea.sNombreAerolinea = dgv_Aerolineas.SelectedRows[0].Cells[1].Value.ToString().Trim();
            objDal_Aerolinea.cIdEstado = Convert.ToChar(dgv_Aerolineas.SelectedRows[0].Cells[3].Value.ToString().Trim());
            frm_ModificarAerolineas Pantalla = new frm_ModificarAerolineas();
            Hide();
            Pantalla.ShowDialog();
            Show();
            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
    }
    
}
