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
            cmb_ID_Estado.DataSource = DTE;
            cmb_ID_Estado.DisplayMember = DTE.Columns[0].ToString();
            #endregion

            #region Combo ID Clientes
            cls_TiposClientes_BLL ObjBLLTipoC = new cls_TiposClientes_BLL();
            string sMsjError1 = string.Empty;
            DataTable DTTC = new DataTable();
            DTTC = ObjBLLTipoC.ListarTiposClientes(ref sMsjError1);
            cmb_ID_Tipo_Cliente.DataSource = DTTC;
            cmb_ID_Tipo_Cliente.DisplayMember = DTTC.Columns[0].ToString();
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
            if ((mtxt_Cedula.SelectionStart == 0) && (e.KeyChar == '0'))
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
            if ((mtxt_Telefono.SelectionStart == 0) && mtxt_Telefono.Text == "0")
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
            if (ObjClientes_DAL.cBandAxn == 'I')
            {

            }
            else
            {

            }
        }
    }
}
