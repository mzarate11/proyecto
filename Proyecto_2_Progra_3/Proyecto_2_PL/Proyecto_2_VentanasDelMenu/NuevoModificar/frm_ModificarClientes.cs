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
    public partial class frm_ModificarClientes : Form
    {
        public cls_Clientes_DAL ObjClientes_DAL;
        public frm_ModificarClientes()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            #region Combo ID Estados
            cls_Estados_BLL ObjBLLEstados = new cls_Estados_BLL();
            string sMsjError = string.Empty;
            DataTable DTE = new DataTable();
            DTE = ObjBLLEstados.Listar_Estados(ref sMsjError);


            DTE.Rows.Add("0", "SELECCIONE UN ESTADO");


            cmb_ID_Estado.DataSource = DTE;
            cmb_ID_Estado.DisplayMember = DTE.Columns[1].ToString();
            cmb_ID_Estado.ValueMember = DTE.Columns[0].ToString();
            cmb_ID_Estado.SelectedValue = "0";
            #endregion

            #region Combo ID Clientes
            cls_TiposClientes_BLL ObjBLLTipoC = new cls_TiposClientes_BLL();
            string sMsjError1 = string.Empty;
            DataTable DTTC = new DataTable();
            DTTC = ObjBLLTipoC.ListarTiposClientes(ref sMsjError1);

            DTTC.Rows.Add("0", "SELECCIONE UN ID CLIENTE");

            cmb_ID_Tipo_Cliente.DataSource = DTTC;
            cmb_ID_Tipo_Cliente.DisplayMember = DTTC.Columns[1].ToString();
            cmb_ID_Tipo_Cliente.ValueMember = DTTC.Columns[0].ToString();
            cmb_ID_Tipo_Cliente.SelectedValue = "0";
            #endregion


            if (ObjClientes_DAL != null)
            {
                if (ObjClientes_DAL.cBandAxn == 'I')
                {
                    txt_ID_Cliente.Text = string.Empty;
                    txt_ID_Cliente.Enabled = true;
                    mtxt_Cedula.Text = string.Empty;
                    txt_Nombre.Text = string.Empty;
                    txt_Apellidos.Text = string.Empty;
                    mtxt_Telefono.Text = string.Empty;
                }
                else
                {
                    txt_ID_Cliente.Text = ObjClientes_DAL.sIdCliente.ToString().Trim();
                    txt_ID_Cliente.Enabled = false;
                    mtxt_Cedula.Text = ObjClientes_DAL.sCedula.ToString().Trim();
                    txt_Nombre.Text = ObjClientes_DAL.sNombre.ToString().Trim();
                    txt_Apellidos.Text = ObjClientes_DAL.sApellido.ToString().Trim();
                    mtxt_Telefono.Text = ObjClientes_DAL.sTelefono.ToString().Trim();
                }
            }
            else
            {
                MessageBox.Show("Se presentó un error de capa 8 de programador. \n\nFavor Contactar a soporte técnico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }


        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSymbol(e.KeyChar))|| (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_ID_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSeparator(e.KeyChar))||(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txt_Apellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSymbol(e.KeyChar))|| (e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void mtxt_Cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((mtxt_Cedula.SelectionStart == '0') && (e.KeyChar == '0'))
            {
                e.Handled = true;
                MessageBox.Show("La cédula no puede iniciar con 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                
            }
            else
            {
                if ((char.IsLetter(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSymbol(e.KeyChar)) || (e.KeyChar == ' '))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            }
        }

        private void mtxt_Telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '0') && mtxt_Telefono.Text == "")
            {
                MessageBox.Show("El teléfono no puede iniciar con 0", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if ((char.IsLetter(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSymbol(e.KeyChar)) || (e.KeyChar == ' '))
                {
                    e.Handled = true;
                }
                else
                {
                    e.Handled = false;
                }
            
         }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_ModificarClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((cmb_ID_Estado.SelectedValue.ToString() != "0") || (cmb_ID_Tipo_Cliente.SelectedValue.ToString() != "0"))
            {
                string sMsjError = string.Empty;
                cls_Clientes_BLL ObjClientes_BLL = new cls_Clientes_BLL();
                ObjClientes_DAL.sIdCliente = txt_ID_Cliente.Text;
                ObjClientes_DAL.sCedula = mtxt_Cedula.Text;
                ObjClientes_DAL.sNombre = txt_Nombre.Text;
                ObjClientes_DAL.sApellido = txt_Apellidos.Text;
                ObjClientes_DAL.sTelefono = mtxt_Telefono.Text;
                ObjClientes_DAL.sIdTipoCliente = cmb_ID_Tipo_Cliente.SelectedValue.ToString();
                ObjClientes_DAL.cIdEstado = Convert.ToChar(cmb_ID_Estado.SelectedValue.ToString());

                if (ObjClientes_DAL.cBandAxn == 'I')
                {
                    ObjClientes_BLL.Insertar_Clientes(ref sMsjError, ref ObjClientes_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("La Base de Datos ha sido actualizada", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un Error y los Datos no han sido agregados:" + " [ " + sMsjError + " ] ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if ((ObjClientes_DAL.cBandAxn == 'U') || (ObjClientes_DAL != null))
                {

                    ObjClientes_BLL.Modificar_Clientes(ref sMsjError, ref ObjClientes_DAL);

                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("La Base de Datos ha sido actualizada", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un Error y los Datos no han sido agregados:" + " [ " + sMsjError + " ] ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                
            }
            else
            {
                MessageBox.Show("No se puede guardar sin no están todos los datos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
