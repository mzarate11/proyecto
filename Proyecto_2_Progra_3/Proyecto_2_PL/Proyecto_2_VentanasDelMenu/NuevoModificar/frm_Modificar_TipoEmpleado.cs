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
    public partial class frm_Modificar_TipoEmpleado : Form
    {

        public cls_TipoEmpleados_DAL Obj_DAL_TipoEmpleado;
        public frm_Modificar_TipoEmpleado()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            if (Obj_DAL_TipoEmpleado != null)
            {
                cls_TiposEmpleados_BLL Obj_Tipos_Empleados_BLL = new cls_TiposEmpleados_BLL();
                string sMsjError = string.Empty;

                DataTable DTLE = new DataTable();
                DTLE= Obj_Tipos_Empleados_BLL.ListarTiposEmpleados(ref sMsjError);


                DTLE.Rows.Add("0", "--SELECCIONE UN ESTADO--");

                cmb_IDEstado.DataSource = DTLE;
                cmb_IDEstado.DisplayMember = DTLE.Columns[1].ToString();
                cmb_IDEstado.ValueMember = DTLE.Columns[0].ToString();

                cmb_IDEstado.SelectedValue = "0";

                if (Obj_DAL_TipoEmpleado.CBandAX == 'I')
                {
                    txt_IDTipoEmpleado.Text = string.Empty;
                    txt_IDTipoEmpleado.Enabled = true;
                    txt_desc.Text = string.Empty;
                    cmb_IDEstado.DataSource = null;
                    
                }
                else
                {
                    txt_IDTipoEmpleado.Text = Obj_DAL_TipoEmpleado.ITipoEmpleado.ToString().Trim();
                    txt_IDTipoEmpleado.Enabled = false;
                    txt_desc.Text = Obj_DAL_TipoEmpleado.SDescTipo.ToString().Trim();
                    cmb_IDEstado.Text = Obj_DAL_TipoEmpleado.SDescTipo.ToString().Trim();
                    
                }
            }
            else
            {
                MessageBox.Show("Se presento un error capa8", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void frm_Modificar_TipoEmpleado_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (cmb_IDEstado.SelectedValue.ToString() != "0" ||
               txt_IDTipoEmpleado.Text != string.Empty ||
               txt_desc.Text != string.Empty )
                
            {
                cls_TiposEmpleados_BLL obj_TipoEmpleado_BLL = new cls_TiposEmpleados_BLL();
                string sMsjError = string.Empty;
                Obj_DAL_TipoEmpleado.ITipoEmpleado = Convert.ToInt32(txt_IDTipoEmpleado.Text.Trim());
                Obj_DAL_TipoEmpleado.SDescTipo = txt_desc.Text.Trim();
                Obj_DAL_TipoEmpleado.CIdEstado = Convert.ToChar(cmb_IDEstado.Text.Trim());

                if (Obj_DAL_TipoEmpleado.CBandAX == 'I')
                {
                    obj_TipoEmpleado_BLL.Insertar_TipoEmpleado(ref sMsjError, ref Obj_DAL_TipoEmpleado);

                    if (sMsjError == string.Empty)
                    {

                        MessageBox.Show("Se modifico el registro exitosamente");
                    }
                    else {

                        MessageBox.Show("Se presento un error");
                    }
                }
                else
                {
                    obj_TipoEmpleado_BLL.Modificat_TipoEmpleado(ref sMsjError, ref Obj_DAL_TipoEmpleado);
                }
            }
            else
            {
                MessageBox.Show("Todos los cambios son obligatorios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         }

        private void txt_desc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSeparator(e.KeyChar)) || (char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void cmb_IDEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSeparator(e.KeyChar)) || (char.IsSymbol(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_IDTipoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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
