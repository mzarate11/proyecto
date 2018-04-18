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

                cls_Estados_BLL ObjBLLEstados = new cls_Estados_BLL();
                DataTable DTE = new DataTable();
                DTE = ObjBLLEstados.Listar_Estados(ref sMsjError);
                DTE.Rows.Add("0", "--SELECCIONE UN ESTADO--");
                cmb_IDEstado.DataSource = DTE;
                cmb_IDEstado.DisplayMember = DTE.Columns[1].ToString();
                cmb_IDEstado.ValueMember = DTE.Columns[0].ToString();
                cmb_IDEstado.SelectedValue = "0";

                txt_IDTipoCliente.Enabled = false;

                if (Obj_DAL_TiposClientes.CBandAX == 'I')
                {
                    txt_IDTipoCliente.Text = string.Empty;
                    txt_TipoCliente.Text = string.Empty;
                    txt_descripcion.Text = string.Empty;


                }
                else
                {
                    toolStripLabel3.Text = "Modificar";
                    txt_IDTipoCliente.Text = Obj_DAL_TiposClientes.IIdTipoCliente.ToString().Trim();
                    txt_TipoCliente.Text = Obj_DAL_TiposClientes.STipoCliente.ToString().Trim();
                    txt_descripcion.Text = Obj_DAL_TiposClientes.SDescripcion.ToString().Trim();
                    cmb_IDEstado.SelectedValue = Obj_DAL_TiposClientes.CIdEstado.ToString().Trim();

                }

            }
            else {
                MessageBox.Show("Se presento un error capa 8 del programador ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }
       
        private void frm_Modificar_TipoClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        

        private void txt_IDTipoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Este espacio es solo para ingresar numeros", "Informacion",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void txt_descripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back) || e.KeyChar == (char)(Keys.Space))
                {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Este espacio es solo para ingresar letras", "Informacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
            }
        }

        private void txt_TipoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back) || e.KeyChar == (char)(Keys.Space))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este espacio es solo para ingresar letras", "Informacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmb_IDEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
             e.Handled = true;
            MessageBox.Show("Este campo no se puede editar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txt_IDTipoCliente.Text != string.Empty ||
                                txt_descripcion.Text != string.Empty ||
                                txt_TipoCliente.Text != string.Empty ||
                                cmb_IDEstado.SelectedValue.ToString() != "0")
            {
                cls_TiposClientes_BLL obj_TiposClientes_BLL = new cls_TiposClientes_BLL();
                string sMsjError = string.Empty;
                Obj_DAL_TiposClientes.CIdEstado = Convert.ToChar(cmb_IDEstado.SelectedValue.ToString().Trim());
                Obj_DAL_TiposClientes.STipoCliente = txt_TipoCliente.Text.Trim();
                Obj_DAL_TiposClientes.SDescripcion = txt_descripcion.Text.Trim();

                if (Obj_DAL_TiposClientes.CBandAX == 'I')
                {
                    obj_TiposClientes_BLL.Insertar_TipoCliente(ref sMsjError, ref Obj_DAL_TiposClientes);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se han ingresado los datos correctamente");
                        Obj_DAL_TiposClientes.CBandAX = 'U';
                        toolStripLabel3.Text = "Modificar";
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error" + "[ " + sMsjError + " ]");
                    }

                }
                else
                {
                    obj_TiposClientes_BLL.Modificar_TipoCliente(ref sMsjError, ref Obj_DAL_TiposClientes);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se han ingresado los datos correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error");
                    }
                }
            }
            else
            {

                MessageBox.Show("Todos los cambios son obligatorios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    }

