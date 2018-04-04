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
    public partial class frm_Modificar_Usuarios : Form
    {
        #region Instacia Usuario publico
        public cls_T_Usuarios_DAL Obj_Usuarios_Dal;
        #endregion

        public frm_Modificar_Usuarios()
        {
            InitializeComponent();
        }

        #region Load
        private void frm_Modificar_Usuarios_Load(object sender, EventArgs e)
        {
            txt_Username.Enabled = false;
            string sMsjError = string.Empty;
            cls_Estados_BLL objCateVuelo = new cls_Estados_BLL();
            cls_Empleados_BLL objUsuario = new  cls_Empleados_BLL();

            DataTable DTUe = new DataTable();
            DataTable DTUEm = new DataTable();

            DTUe = objCateVuelo.Listar_Estados(ref sMsjError);
            DTUEm = objUsuario.Listar_Empleados(ref sMsjError);

            DTUe.Rows.Add("0", "--- Selecione un Estado ---");
            DTUEm.Rows.Add("0", "--- Selecione un Estado ---");

            cmb_IdEstado.DataSource = DTUe;
            cmb_IdEmpleado.DataSource = DTUEm;

            cmb_IdEmpleado.DisplayMember = DTUe.Columns[1].ToString();
            cmb_IdEmpleado.ValueMember = DTUe.Columns[0].ToString();

            cmb_IdEstado.DisplayMember = DTUe.Columns[1].ToString();
            cmb_IdEstado.ValueMember = DTUe.Columns[0].ToString();

            cmb_IdEmpleado.SelectedValue = "0";
            cmb_IdEstado.SelectedValue = "0";
            CargarDatos();
        }
        #endregion

        #region Proceso Cargar Datos
        private void CargarDatos()
        {
            #region Combo ID Estados
            //cls_Estados_BLL ObjBLLEstados = new cls_Estados_BLL();
            //string sMsjError = string.Empty;
            // DataTable DTE = new DataTable();
            /// DTE = ObjBLLEstados.Listar_Estados(ref sMsjError);
            // cmb_IdEstado.DataSource = DTE;
            // cmb_IdEstado.DisplayMember = DTE.Columns[0].ToString();
            #endregion

            #region Combo ID Empleado
            // cls_Empleados_BLL ObjBLL_Empleados = new cls_Empleados_BLL();
            //  DataTable DT = new DataTable();
            // DT = ObjBLL_Empleados.Listar_Empleados(ref sMsjError);
            //  cmb_IdEmpleado.DataSource = DT;
            //  cmb_IdEmpleado.DisplayMember = DT.Columns[0].ToString();
            #endregion


            if (Obj_Usuarios_Dal != null)
            {
                if (Obj_Usuarios_Dal.cBandAX == 'I')
                {
                    txt_Username.Enabled = true;
                    Obj_Usuarios_Dal.sUsername = string.Empty;
                    Obj_Usuarios_Dal.sPassword = string.Empty;

                }
                else
                {
                    txt_Username.Text = Obj_Usuarios_Dal.sUsername.ToString().Trim();
                    txt_Username.Enabled = false;
                    txt_Password.Text = Obj_Usuarios_Dal.sPassword.ToString().Trim();

                }
            }
            else
            {
                MessageBox.Show("Se presentó un error de capa 8 de programador. \n\nFavor Contactar a soporte técnico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        #endregion

        #region Boton Guardar
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string sMsjError = string.Empty;
            Obj_Usuarios_Dal.sUsername = txt_Username.Text;
            Obj_Usuarios_Dal.sPassword = txt_Password.Text;
            Obj_Usuarios_Dal.sIdEmpleado =Convert.ToString( cmb_IdEmpleado.SelectedValue);

            Obj_Usuarios_Dal.cIdEstado= Convert.ToChar(cmb_IdEstado.SelectedValue);
            if (Obj_Usuarios_Dal.cBandAX == 'I')
            {
                cls_Usuarios_BLL Obj_ManteniUsuarios_BLL = new  cls_Usuarios_BLL();

                Obj_ManteniUsuarios_BLL.Insertar_Usuarios(ref sMsjError, ref Obj_Usuarios_Dal);

                if (sMsjError == string.Empty)
                {
                    MessageBox.Show("La Base de Datos ha sido Actualizada", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error al ingresar los datos a la base de datos:" + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }
        #endregion

        #region Boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Validaciones de los texbox
        private void txt_Username_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_Password_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (char.IsNumber(e.KeyChar)))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }

        #endregion

    } /// fin

}
