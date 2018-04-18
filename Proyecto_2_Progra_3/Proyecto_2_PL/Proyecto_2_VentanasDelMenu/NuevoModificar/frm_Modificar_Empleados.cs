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
            if (Obj_Empleados_DAL.cBandera=='U')
            {
                txt_IdEmpleado.Enabled = false;
            }
            else
            {
                txt_IdEmpleado.Enabled = true;
            }
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
                DT_Estados.Rows.Add("0", "-- Seleccione un valor --");
                cb_Estado.DisplayMember = DT_Estados.Columns[1].ToString();
                cb_Estado.ValueMember = DT_Estados.Columns[0].ToString();

                cb_Estado.SelectedValue = "0";
                #endregion

                #region ID Tipo Empleado
                cls_TiposEmpleados_BLL ObjTipoEmpleados = new cls_TiposEmpleados_BLL();
                DataTable DT_TipoEmpleados = new DataTable();
                DT_TipoEmpleados = ObjTipoEmpleados.ListarTiposEmpleados(ref M_Error);
                DT_TipoEmpleados.Rows.Add("0", "-- Seleccione un valor --");
                cb_TipoEmpleado.DataSource = DT_TipoEmpleados;
                cb_TipoEmpleado.DisplayMember = DT_TipoEmpleados.Columns[1].ToString();
                cb_TipoEmpleado.ValueMember = DT_TipoEmpleados.Columns[0].ToString();
                cb_TipoEmpleado.SelectedValue = "0";
                #endregion

                #region ID Aerolinea
                cls_Aerolineas_BLL ObjAerolinea = new cls_Aerolineas_BLL();
                DataTable DT_Aerolinea = new DataTable();
                DT_Aerolinea = ObjAerolinea.ListarAerolineas(ref M_Error);
                DT_Aerolinea.Rows.Add("0", "-- Seleccione un valor --");
                cb_IdAerolinea.DataSource = DT_Aerolinea;
                cb_IdAerolinea.DisplayMember = DT_Aerolinea.Columns[1].ToString();
                cb_IdAerolinea.ValueMember = DT_Aerolinea.Columns[0].ToString();
                cb_IdAerolinea.SelectedValue = "0";
                #endregion

                if (Obj_Empleados_DAL.cBandera == 'I')
                {
                    txt_Direccion.Clear();
                    txt_Nombre.Clear();
                    txt_Apellidos.Clear();
                    txt_Edad.Clear();
                    txt_IdEmpleado.Clear();
                    txt_Salario.Clear();
                    txt_Cedula.Clear();
                    txt_Celular.Clear();
                    txt_TelCasa.Clear();
                    txt_TelRef.Clear();
                }
                else
                {
                    txt_Direccion.Text = Obj_Empleados_DAL.sDireccion;
                    txt_Nombre.Text = Obj_Empleados_DAL.sNombre;
                    txt_Apellidos.Text = Obj_Empleados_DAL.sApellidos;
                    txt_Edad.Text = Obj_Empleados_DAL.bEdad.ToString().Trim();
                    txt_IdEmpleado.Text = Obj_Empleados_DAL.uIdEmpleado.ToString().Trim();
                    txt_Salario.Text = Obj_Empleados_DAL.dSalario.ToString().Trim();
                    txt_Cedula.Text = Obj_Empleados_DAL.iCedula.ToString().Trim();
                    txt_Celular.Text = Obj_Empleados_DAL.iCelular.ToString().Trim();
                    txt_TelCasa.Text = Obj_Empleados_DAL.iTelCasa.ToString().Trim();
                    txt_TelRef.Text = Obj_Empleados_DAL.iTelRef.ToString().Trim();
                    
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }

            else if (e.KeyChar == (char)Keys.Space)
            {
                if (string.IsNullOrEmpty(txt_Apellidos.Text))
                {
                    e.Handled = true;
                }
                else if (txt_Apellidos.Text.Contains(' '))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
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
                if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back )
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == (char)Keys.Space)
                {
                    if (string.IsNullOrEmpty(txt_Apellidos.Text))
                    {
                        e.Handled = true;
                    }
                    else if (txt_Apellidos.Text.Contains(' '))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
            
        }

        private void tls_btn_Guardar_Click(object sender, EventArgs e)
        {
            

        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (string.IsNullOrEmpty(txt_Edad.Text) && e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;

                }
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
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
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
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (string.IsNullOrEmpty(txt_Salario.Text) && e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;

                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_TelCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar ==(char)Keys.Back )
            {
               if (string.IsNullOrEmpty(txt_TelCasa.Text) && e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;

                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Celular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (string.IsNullOrEmpty(txt_Celular.Text) && e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;

                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (string.IsNullOrEmpty(txt_Cedula.Text) && e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;

                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_TelRef_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                if (string.IsNullOrEmpty(txt_TelRef.Text) && e.KeyChar == '0')
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;

                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void tlsbtn_Guardar_Click(object sender, EventArgs e)
        {
            cls_Empleados_BLL Obj_Empleados_BLL = new cls_Empleados_BLL();
            string M_Error = string.Empty;

            Obj_Empleados_DAL.sNombre = txt_Nombre.Text;
            Obj_Empleados_DAL.sApellidos = txt_Apellidos.Text;
            Obj_Empleados_DAL.bEdad = Convert.ToByte(txt_Edad.Text);
            Obj_Empleados_DAL.sDireccion = txt_Direccion.Text;
            Obj_Empleados_DAL.iCedula = Convert.ToInt32(txt_Cedula.Text);
            Obj_Empleados_DAL.iCelular = Convert.ToInt32(txt_Celular.Text);
            Obj_Empleados_DAL.iTelCasa = Convert.ToInt32(txt_TelCasa.Text);
            Obj_Empleados_DAL.iTelRef = Convert.ToInt32(txt_TelRef.Text);
            Obj_Empleados_DAL.uIdEmpleado = Convert.ToUInt16(txt_IdEmpleado.Text);
            Obj_Empleados_DAL.dSalario = Convert.ToDouble(txt_Salario.Text);
            Obj_Empleados_DAL.cIdEstado = Convert.ToChar(cb_Estado.SelectedValue.ToString().Trim());
            Obj_Empleados_DAL.iIdTipoEmpleado = Convert.ToInt32(cb_TipoEmpleado.SelectedValue.ToString().Trim());
            Obj_Empleados_DAL.iIdAerolinea = Convert.ToInt32(cb_IdAerolinea.SelectedValue.ToString().Trim());

            if (Obj_Empleados_DAL.cBandera == 'I')
            {
                Obj_Empleados_BLL.Insertar_Empleados(ref M_Error, ref Obj_Empleados_DAL);
                if (M_Error == string.Empty)
                {
                    MessageBox.Show("Se ha ingresado un nuevo Empleado");
                    Obj_Empleados_DAL.cBandera = 'U';
                    txt_IdEmpleado.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Se ha presentado un error al guardar");
                }

            }
            else
            {
                Obj_Empleados_BLL.Modificar_Empleados(ref M_Error, ref Obj_Empleados_DAL);
                if (M_Error == string.Empty)
                {
                    Obj_Empleados_DAL.cBandera = 'U';
                    MessageBox.Show("Se ha realizado el cambio exitosamente");
                    txt_IdEmpleado.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Se ha presentado un error al guardar");
                }
            }
        }

        private void tlsbtn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
