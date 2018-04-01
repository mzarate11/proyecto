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

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    public partial class frm_Modificar_T_CategoriasVuelos : Form
    {
        public cls_T_CategoriasVuelos_DAL Obj_ManteCategorias_DAL;

        public frm_Modificar_T_CategoriasVuelos()
        {
            InitializeComponent();
        }

        #region Boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();

        }
        #endregion

        #region Validar Descripcion
        private void tb_DescCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = true;

                MessageBox.Show("Este campo solo permite letras", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                e.Handled = false;
            }
        }
        #endregion

        #region Validar ID Categoria
        private void tb_IdCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Este Campo no es editable", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            e.Handled = true;
        }
        #endregion

        #region Boton Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Obj_ManteCategorias_DAL.cBandAX == 'I')
            {

            }
            else
            {

            }
        }
        #endregion

        #region no aplica
        private void frm_Modificar_T_CategoriasVuelos_Load(object sender, EventArgs e)
        {

          //  CargarDatos();

        }
        #endregion  

        #region CargarDatos
        private void CargarDatos()
        {
            #region Combo ID Estados
            // cls_Estados_BLL ObjBLLEstados = new cls_Estados_BLL();
            // string sMsjError = string.Empty;
            // DataTable DTE = new DataTable();
            // DTE = ObjBLLEstados.Listar_Estados(ref sMsjError);
            // cmb_IdEstado.DataSource = DTE;
            // cmb_IdEstado.DisplayMember = DTE.Columns[0].ToString();
            #endregion




            if (Obj_ManteCategorias_DAL != null)
            {
                if (Obj_ManteCategorias_DAL.cBandAX == 'I')
                {
                    tb_IdCategoria.Enabled = false;
                    lbiIdCategoria.Enabled = false;
                    tb_DescCategoria.Text = string.Empty;


                }
                else
                {
                    tb_IdCategoria.Text = Obj_ManteCategorias_DAL.iIdCategoria.ToString().Trim();
                    tb_IdCategoria.Enabled = false;
                    tb_DescCategoria.Text = Obj_ManteCategorias_DAL.sDescCategoria.ToString().Trim();
                    cmb_IdEstado.Text = Obj_ManteCategorias_DAL.cIdEstado.ToString().Trim();
                }
            }
            else
            {
                MessageBox.Show("Se presentó un error de capa 8 de programador. \n\nFavor Contactar a soporte técnico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        #endregion

        private void frm_Modificar_T_CategoriasVuelos_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
