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
    public partial class frm_Usuarios : Form
    {
        #region Instacia Usuarios
        cls_T_Usuarios_DAL Obj_Usuarios_DAL;
        #endregion
        public frm_Usuarios()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            cls_Usuarios_BLL obj_User_BLL = new cls_Usuarios_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            if (txtFiltro.Text == string.Empty)
            {
                DT = obj_User_BLL.ListarUsuarios(ref sMsjError);
            }
            else
            {
                DT = obj_User_BLL.FiltrarUsuarios(ref sMsjError, txtFiltro.Text.Trim());
            }

            if (sMsjError == string.Empty)
            {
                dgv_Usuarios.DataSource = null;
                dgv_Usuarios.DataSource = DT;
            }
            else
            {
                dgv_Usuarios.DataSource = null;

                MessageBox.Show("Se presento un error a la hora de listar los estados.\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void MenuVentana_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dgv_Usuarios.DataSource = null;
            CargarDatos();
        }

        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("No se puede eliminar usuarios solo modificar ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //cls_Usuarios_BLL objBLL = new cls_Usuarios_BLL();
            //string sMsjError = string.Empty;

            ///if (dgv_Usuarios.Rows.Count > 1)
           // {
             ///   if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
              //  {
                 //   objBLL.Eliminar_Usuarios(ref sMsjError, dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString());

                 //   if (sMsjError != string.Empty)
                   /// {
                   //     MessageBox.Show("Se presento un error a la hora de listar : [ " + sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // }
                   // else
                   /// {
                     //   MessageBox.Show("Registro eliminado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     //   CargarDatos();
                   // }
                  //  txtFiltro.Text = string.Empty;
               // }
           // }
           // else
            //{
             //   MessageBox.Show("No hay registros para eliminar o solo existe un usuario en la base de datos.");
            //}
        }

        #region boton Refrescar
        private void btn_Refrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }
        #endregion

        #region Boton Nuevo
        private void bnt_Nuevo_Click(object sender, EventArgs e)
        {
            Obj_Usuarios_DAL = new cls_T_Usuarios_DAL();
            NuevoModificar.frm_Modificar_Usuarios PantEstados = new NuevoModificar.frm_Modificar_Usuarios();
            Obj_Usuarios_DAL.cBandAX = 'I';
            PantEstados.Obj_Usuarios_Dal = Obj_Usuarios_DAL;
            PantEstados.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
        #endregion

        #region Boton Modificar
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Obj_Usuarios_DAL = new cls_T_Usuarios_DAL();
            NuevoModificar.frm_Modificar_Usuarios PantEstados = new NuevoModificar.frm_Modificar_Usuarios();
            Obj_Usuarios_DAL.cBandAX = 'U';
            Obj_Usuarios_DAL.sUsername = dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString().Trim();
            Obj_Usuarios_DAL.sPassword = dgv_Usuarios.SelectedRows[0].Cells[1].Value.ToString().Trim();
            Obj_Usuarios_DAL.sIdEmpleado = dgv_Usuarios.SelectedRows[0].Cells[2].Value.ToString().Trim();
            Obj_Usuarios_DAL.cIdEstado = Convert.ToChar(dgv_Usuarios.SelectedRows[0].Cells[3].Value.ToString().Trim());
            PantEstados.Obj_Usuarios_Dal = Obj_Usuarios_DAL;
            PantEstados.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
        #endregion

        #region Doble click
        private void dgv_Usuarios_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Obj_Usuarios_DAL = new cls_T_Usuarios_DAL();
            NuevoModificar.frm_Modificar_Usuarios PantEstados = new NuevoModificar.frm_Modificar_Usuarios();
            Obj_Usuarios_DAL.cBandAX = 'U';
            Obj_Usuarios_DAL.sUsername = dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString().Trim();
            Obj_Usuarios_DAL.sPassword = dgv_Usuarios.SelectedRows[0].Cells[1].Value.ToString().Trim();
            Obj_Usuarios_DAL.sIdEmpleado = dgv_Usuarios.SelectedRows[0].Cells[2].Value.ToString().Trim();
            Obj_Usuarios_DAL.cIdEstado = Convert.ToChar(dgv_Usuarios.SelectedRows[0].Cells[3].Value.ToString().Trim());
            PantEstados.Obj_Usuarios_Dal = Obj_Usuarios_DAL;
            PantEstados.ShowDialog();

            txtFiltro.Text = string.Empty;
            CargarDatos();
        }
        #endregion

        public void user(string user)
        {
            LbUser.Text = user;
        }

    }
}
