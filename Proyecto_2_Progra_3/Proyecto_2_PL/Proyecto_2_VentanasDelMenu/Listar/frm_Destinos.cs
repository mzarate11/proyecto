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
    public partial class frm_Destinos : Form
    {
        public frm_Destinos()
        {
            InitializeComponent();
        }

        cls_Destinos_DAL ObjDestinos_DAL;
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

        private void tls_btn_Modificar_Click(object sender, EventArgs e)
        {
            frm_Modificar_Destinos ModificarDestinos = new frm_Modificar_Destinos();
            if (dgv_Destinos.RowCount > 0)
            {
                ObjDestinos_DAL = new cls_Destinos_DAL();

                ObjDestinos_DAL.cBandera = 'U';
                ObjDestinos_DAL.sIdDestino = dgv_Destinos.SelectedRows[0].Cells[0].Value.ToString().Trim();
                ObjDestinos_DAL.bIdAerolinea = Convert.ToByte(dgv_Destinos.SelectedRows[0].Cells[1].Value);
                ObjDestinos_DAL.sNomDestino = dgv_Destinos.SelectedRows[0].Cells[2].Value.ToString().Trim();
                ObjDestinos_DAL.bPaisSalida = Convert.ToByte(dgv_Destinos.SelectedRows[0].Cells[3].Value);
                ObjDestinos_DAL.bPaisLlegada = Convert.ToByte(dgv_Destinos.SelectedRows[0].Cells[4].Value);
                ObjDestinos_DAL.cIdEstado = Convert.ToChar(dgv_Destinos.SelectedRows[0].Cells[5].Value);

                ModificarDestinos.Obj_Destinos_DAL = ObjDestinos_DAL;
                Hide();
                ModificarDestinos.ShowDialog();

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
            frm_Modificar_Destinos ModificarDestinos = new frm_Modificar_Destinos();
            ObjDestinos_DAL = new cls_Destinos_DAL();

            ObjDestinos_DAL.cBandera = 'I';
            ObjDestinos_DAL.sIdDestino = string.Empty;
            ObjDestinos_DAL.bIdAerolinea = 0;
            ObjDestinos_DAL.sNomDestino = string.Empty;
            ObjDestinos_DAL.bPaisSalida = 0;
            ObjDestinos_DAL.bPaisLlegada = 0;
            ObjDestinos_DAL.cIdEstado = ' ';

            ModificarDestinos.Obj_Destinos_DAL = ObjDestinos_DAL;
            Hide();
            ModificarDestinos.ShowDialog();

            tls_txt_Filtro.Text = string.Empty;
            CargarDatos();
        }

        private void tls_txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
