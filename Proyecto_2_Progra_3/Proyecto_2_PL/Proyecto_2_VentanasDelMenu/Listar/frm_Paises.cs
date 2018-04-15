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
    public partial class frm_Paises : Form
    {
        cls_Paises_DAL ObjPaises_DAL;
        public frm_Paises()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {

            cls_Paises_BLL ObjPaises_BLL = new cls_Paises_BLL();
            string sMsjError = string.Empty;
            DataTable dtEstados = new DataTable();

            if (tls_txt_Filtro.Text == string.Empty)
            {
                dtEstados = ObjPaises_BLL.ListarPaises(ref sMsjError);
            }
            else
            {
                dtEstados = ObjPaises_BLL.FiltrarPaises(ref sMsjError, tls_txt_Filtro.Text.Trim());
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

        private void frm_Paises_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void tls_btn_Refrescar_Click(object sender, EventArgs e)
        {
            dgv_Paises.DataSource = null;
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
                MessageBox.Show("No hay registros para eliminar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tls_btn_Modificar_Click(object sender, EventArgs e)
        {
            frm_Modificar_Paises ModificarPaises = new frm_Modificar_Paises();
            if (dgv_Paises.RowCount > 0)
            {
                ObjPaises_DAL = new cls_Paises_DAL();

                ObjPaises_DAL.cBandera = 'U';
                ObjPaises_DAL.iIdPais = Convert.ToInt32(dgv_Paises.SelectedRows[0].Cells[0].Value);
                ObjPaises_DAL.sNombrePais = dgv_Paises.SelectedRows[0].Cells[1].Value.ToString().Trim();
                ObjPaises_DAL.sCodigoISOPais = dgv_Paises.SelectedRows[0].Cells[2].Value.ToString().Trim();
                ObjPaises_DAL.sCodigoAreaPais = dgv_Paises.SelectedRows[0].Cells[3].Value.ToString().Trim();
                ObjPaises_DAL.cIdEstado = Convert.ToChar(dgv_Paises.SelectedRows[0].Cells[4].Value);

                ModificarPaises.Obj_Paises_DAL = ObjPaises_DAL;
                Hide();
                ModificarPaises.ShowDialog();

                tls_txt_Filtro.Text = string.Empty;
                CargarDatos();
            }
            else
            {
                MessageBox.Show("No se pueden realizar la acción, debido a que no existen datos por modificar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tls_btn_Nuevo_Click(object sender, EventArgs e)
        {
            ObjPaises_DAL = new cls_Paises_DAL();
            frm_Modificar_Paises ModificarPaises = new frm_Modificar_Paises();

            ObjPaises_DAL.cBandera = 'I';
            ObjPaises_DAL.iIdPais = 0;
            ObjPaises_DAL.sNombrePais = string.Empty;
            ObjPaises_DAL.sCodigoISOPais = string.Empty;
            ObjPaises_DAL.sCodigoAreaPais = string.Empty;
            ObjPaises_DAL.cIdEstado = ' ';

            ModificarPaises.Obj_Paises_DAL = ObjPaises_DAL;
            Hide();
            ModificarPaises.ShowDialog();

            tls_txt_Filtro.Text = string.Empty;
            CargarDatos();
        }
    }
}
