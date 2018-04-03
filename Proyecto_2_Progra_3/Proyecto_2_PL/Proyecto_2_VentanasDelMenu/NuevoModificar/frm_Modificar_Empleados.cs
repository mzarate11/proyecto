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
    public partial class frm_Modificar_Empleados : Form
    {
        public frm_Modificar_Empleados()
        {
            InitializeComponent();
        }
        public cls_Empleados_DAL Obj_Empleados_DAL;

        private void frm_Modificar_Empleados_Load(object sender, EventArgs e)
        {

            CargarDatos();
        }
        public void CargarDatos()
        {
            if (Obj_Empleados_DAL != null)
            {
                string M_Error = string.Empty;
                #region Estados
                cls_Estados_BLL ObjEstados = new cls_Estados_BLL();
                DataTable DT_Estados = new DataTable();
                DT_Estados = ObjEstados.Listar_Estados(ref M_Error);
                cb_Estado.DataSource = DT_Estados;
                cb_Estado.DisplayMember = DT_Estados.Columns[0].ToString();
                #endregion

                #region ID Tipo Empleado
                cls_TiposEmpleados_BLL ObjTipoEmpleados = new cls_TiposEmpleados_BLL();
                DataTable DT_TipoEmpleados = new DataTable();
                DT_TipoEmpleados = ObjTipoEmpleados.ListarTiposEmpleados(ref M_Error);
                cb_TipoEmpleado.DataSource = DT_TipoEmpleados;
                cb_TipoEmpleado.DisplayMember = DT_TipoEmpleados.Columns[0].ToString();
                #endregion

                #region ID Aerolinea
                cls_Aerolineas_BLL ObjAerolinea = new cls_Aerolineas_BLL();
                DataTable DT_Aerolinea = new DataTable();
                DT_Aerolinea = ObjAerolinea.ListarAerolineas(ref M_Error);
                cb_IdAerolinea.DataSource = DT_Aerolinea;
                cb_IdAerolinea.DisplayMember = DT_Aerolinea.Columns[0].ToString();
                #endregion

                if (Obj_Empleados_DAL.cBandera == 'I')
                {
                    txt_Direccion.Clear();
                    txt_Nombre.Clear();
                    txt_Apellidos.Clear();
                    txt_Edad.Clear();
                    txt_IdEmpleado.Clear();
                    txt_Salario.Clear();
                    mb_Cedula.Clear();
                    mb_Celular.Clear();
                    mb_TelCasa.Clear();
                    mb_TelReferencia.Clear();
                }
                else
                {
                    txt_Direccion.Text = Obj_Empleados_DAL.sDireccion;
                    txt_Nombre.Text = Obj_Empleados_DAL.sNombre;
                    txt_Apellidos.Text = Obj_Empleados_DAL.sApellidos;
                    txt_Edad.Text = Obj_Empleados_DAL.bEdad.ToString().Trim();
                    txt_IdEmpleado.Text = Obj_Empleados_DAL.iIdTipoEmpleado.ToString().Trim();
                    txt_Salario.Text = Obj_Empleados_DAL.dSalario.ToString().Trim();
                    mb_Cedula.Text = Obj_Empleados_DAL.iCedula.ToString().Trim();
                    mb_Celular.Text = Obj_Empleados_DAL.iCelular.ToString().Trim();
                    mb_TelCasa.Text = Obj_Empleados_DAL.iTelCasa.ToString().Trim();
                    mb_TelReferencia.Text = Obj_Empleados_DAL.iTelRef.ToString().Trim();
                    
                }         
            }
            else
            {
                MessageBox.Show("Se presentó un error \nContacte al administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void tls_btn_Salir_Click(object sender, EventArgs e)
        {
            frm_Empleados PantallaEmpleados= new frm_Empleados();
            Hide();
            PantallaEmpleados.ShowDialog();
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)|| e.KeyChar==(char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Apellidos.Text) && e.KeyChar ==(char)Keys.Space)
            {
                e.Handled = true;
            }
            else
            {
                if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            
        }

        private void tls_btn_Guardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Nombre.Text) || string.IsNullOrEmpty(txt_Apellidos.Text) || string.IsNullOrEmpty(txt_Edad.Text) ||
                string.IsNullOrEmpty(txt_Direccion.Text) || string.IsNullOrEmpty(mb_Cedula.Text) || string.IsNullOrEmpty(mb_Celular.Text) ||
                string.IsNullOrEmpty(mb_TelCasa.Text) || string.IsNullOrEmpty(mb_TelReferencia.Text)|| string.IsNullOrEmpty(txt_IdEmpleado.Text) ||
                string.IsNullOrEmpty(txt_Salario.Text))
            {
                MessageBox.Show("Debe completar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }

        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Direccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Direccion.Text) && e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_IdEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Salario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
