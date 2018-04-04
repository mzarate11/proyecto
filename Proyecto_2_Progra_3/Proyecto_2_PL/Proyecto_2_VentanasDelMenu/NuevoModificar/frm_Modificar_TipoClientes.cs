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
    public partial class frm_Modificar_TipoClientes : Form
    {
        public cls_TiposClientes_DAL Obj_DAL_TiposClientes;

        public frm_Modificar_TipoClientes()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            cls_TiposClientes_DAL Obj_Tipo_clientes_DAL = new cls_TiposClientes_DAL();
            if (Obj_DAL_TiposClientes != null)
            {
                
                string sMsjError = string.Empty;

                cls_TiposClientes_BLL Obj_Tipo_Clientes_BLL = new cls_TiposClientes_BLL();
                DataTable DTE = new DataTable();
                DTE = Obj_Tipo_Clientes_BLL.ListarTiposClientes(ref sMsjError);

                cmb_IDEstado.DataSource = DTE;
                DTE.Rows.Add("0", "--SELECCIONE UN ESTADO--");

                cmb_IDEstado.DisplayMember = DTE.Columns[1].ToString();
                cmb_IDEstado.ValueMember = DTE.Columns[0].ToString();


                cmb_IDEstado.SelectedValue = "0";


                if (Obj_DAL_TiposClientes.CBandAX == 'I')
                {
                    txt_IDTipoCliente.Text = string.Empty;
                    txt_IDTipoCliente.Enabled = true;
                    txt_TipoCliente.Text = string.Empty;
                    txt_descripcion.Text = string.Empty;
                    cmb_IDEstado.DataSource = null;
                   
                }
                else
                {
                    txt_IDTipoCliente.Text = Obj_DAL_TiposClientes.IIdTipoCliente.ToString().Trim();
                    txt_IDTipoCliente.Enabled = false;
                    txt_TipoCliente.Text = Obj_DAL_TiposClientes.STipoCliente.ToString().Trim();
                    txt_descripcion.Text = Obj_DAL_TiposClientes.SDescripcion.ToString().Trim();
                    cmb_IDEstado.Text = Obj_DAL_TiposClientes.CIdEstado.ToString().Trim();
                  
                }

            }
            else {
                MessageBox.Show("Se presento un error capa 8 del programador ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            {

                cls_TiposClientes_BLL obj_TiposClientes_BLL = new cls_TiposClientes_BLL();

                if (cmb_IDEstado.SelectedValue.ToString() != "0" ||
                    txt_IDTipoCliente.Text != string.Empty ||
                    txt_descripcion.Text != string.Empty ||
                    txt_TipoCliente.Text != string.Empty)
                {
                    string sMsjError = string.Empty;
                    Obj_DAL_TiposClientes.CIdEstado = Convert.ToChar(cmb_IDEstado.SelectedValue.ToString().Trim());
                    Obj_DAL_TiposClientes.IIdTipoCliente = Convert.ToInt32(txt_IDTipoCliente.Text.Trim());
                    Obj_DAL_TiposClientes.STipoCliente = txt_TipoCliente.Text.Trim();
                    Obj_DAL_TiposClientes.SDescripcion = txt_descripcion.Text.Trim();

                    if (Obj_DAL_TiposClientes.CBandAX == 'I')
                    {
                        obj_TiposClientes_BLL.Insertar_TipoCliente(ref sMsjError, ref Obj_DAL_TiposClientes);

                    }
                    else
                    {
                        obj_TiposClientes_BLL.Modificar_TipoCliente(ref sMsjError, ref Obj_DAL_TiposClientes);
                    }
                }
                else {

                    MessageBox.Show("Todos los cambios son obligatorios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
        }

        private void frm_Modificar_TipoClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_IDTipoCliente_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_TipoCliente_KeyPress(object sender, KeyPressEventArgs e)
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
