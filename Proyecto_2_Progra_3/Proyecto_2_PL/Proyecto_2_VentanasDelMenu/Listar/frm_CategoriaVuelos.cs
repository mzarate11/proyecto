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

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu
{
    public partial class frm_CategoriaVuelos : Form
    {
        #region Instacia Categoria Vuelos
        cls_T_CategoriasVuelos_DAL Obj_CategoriasVuelos_DAL;
        #endregion

        public frm_CategoriaVuelos()
        {
            InitializeComponent();
        }

        private void frm_CategoriaVuelos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            cls_T_CategoriasVuelos_BLL Obj_Clientes_BLL = new cls_T_CategoriasVuelos_BLL();
            string sMsjError = string.Empty;
            DataTable dtClientes = new DataTable();

            if (txtFiltro.Text == string.Empty)
            {
                dtClientes = Obj_Clientes_BLL.ListarCategoriasVuelos(ref sMsjError);

            }
            else
            {
                dtClientes = Obj_Clientes_BLL.FiltrarCategoriasAviones(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_CategoriasVuelos.DataSource = null;
                dgv_CategoriasVuelos.DataSource = dtClientes;
            }
            else
            {
                dgv_CategoriasVuelos.DataSource = null;
                MessageBox.Show("Se presentó un error : [ " + sMsjError + " ]. ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cls_T_CategoriasVuelos_BLL objBLL = new cls_T_CategoriasVuelos_BLL();
            string sMsjError = string.Empty;

            if (dgv_CategoriasVuelos.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_CategoriaVuelos(ref sMsjError, dgv_CategoriasVuelos.SelectedRows[0].Cells[0].Value.ToString());

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

    
        #region Boton Nuevo
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            Obj_CategoriasVuelos_DAL = new cls_T_CategoriasVuelos_DAL();

            NuevoModificar.frm_Modificar_T_CategoriasVuelos PantCategoriaVuelo = new NuevoModificar.frm_Modificar_T_CategoriasVuelos();

            Obj_CategoriasVuelos_DAL.cBandAX = 'I';
            PantCategoriaVuelo.Obj_ManteCategorias_DAL = Obj_CategoriasVuelos_DAL;
            PantCategoriaVuelo.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
        #endregion

        #region Boton Modificar
        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Obj_CategoriasVuelos_DAL = new cls_T_CategoriasVuelos_DAL();

            NuevoModificar.frm_Modificar_T_CategoriasVuelos PantCategoriaVuelo = new NuevoModificar.frm_Modificar_T_CategoriasVuelos();

            Obj_CategoriasVuelos_DAL.cBandAX = 'U';
            Obj_CategoriasVuelos_DAL.iIdCategoria = Convert.ToChar(dgv_CategoriasVuelos.SelectedRows[0].Cells[0].Value.ToString().Trim());
            Obj_CategoriasVuelos_DAL.sDescCategoria = dgv_CategoriasVuelos.SelectedRows[0].Cells[1].Value.ToString().Trim();
            Obj_CategoriasVuelos_DAL.cIdEstado = Convert.ToChar(dgv_CategoriasVuelos.SelectedRows[0].Cells[2].Value.ToString().Trim());
            PantCategoriaVuelo.Obj_ManteCategorias_DAL = Obj_CategoriasVuelos_DAL;
            PantCategoriaVuelo.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
        #endregion

        #region dgv_Estado doble Click
        private void dgv_CategoriasVuelos_RowHeaderMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            Obj_CategoriasVuelos_DAL = new cls_T_CategoriasVuelos_DAL();

            NuevoModificar.frm_Modificar_T_CategoriasVuelos PantCategoriaVuelo = new NuevoModificar.frm_Modificar_T_CategoriasVuelos();

            Obj_CategoriasVuelos_DAL.cBandAX = 'U';
            Obj_CategoriasVuelos_DAL.iIdCategoria = Convert.ToChar(dgv_CategoriasVuelos.SelectedRows[0].Cells[0].Value.ToString().Trim());
            Obj_CategoriasVuelos_DAL.sDescCategoria = dgv_CategoriasVuelos.SelectedRows[0].Cells[1].Value.ToString().Trim();
            Obj_CategoriasVuelos_DAL.cIdEstado = Convert.ToChar(dgv_CategoriasVuelos.SelectedRows[0].Cells[2].Value.ToString().Trim());
            PantCategoriaVuelo.Obj_ManteCategorias_DAL = Obj_CategoriasVuelos_DAL;
            PantCategoriaVuelo.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
        #endregion

    }
}
