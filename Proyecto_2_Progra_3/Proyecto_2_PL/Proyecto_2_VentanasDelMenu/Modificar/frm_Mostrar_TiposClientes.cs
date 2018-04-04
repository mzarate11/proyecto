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

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.Modificar
{
    public partial class frm_Mostrar_TiposClientes : Form
    {
        public cls_TiposClientes_DAL OBj_DAL_TiposClientes;


        public frm_Mostrar_TiposClientes()
        {
            InitializeComponent();
        }

        private void frm_Mostrar_TiposClientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            cls_TiposClientes_BLL obj_TiposClientes_BLL = new cls_TiposClientes_BLL();
            string sMsjError = string.Empty;
            OBj_DAL_TiposClientes.CIdEstado = Convert.ToChar(cmb_IDEstado.Text.Trim());
            OBj_DAL_TiposClientes.IIdTipoCliente = Convert.ToInt32(txt_IDTipoCliente.Text.Trim());
            OBj_DAL_TiposClientes.STipoCliente = txt_TipoCliente.Text.Trim();
            OBj_DAL_TiposClientes.SDescripcion = txt_descripcion.Text.Trim();

            if (OBj_DAL_TiposClientes.CBandAX == 'I')
            {
                obj_TiposClientes_BLL.Insertar_TipoCliente(ref sMsjError, ref OBj_DAL_TiposClientes);

            }
            else
            {
                obj_TiposClientes_BLL.Modificar_TipoCliente(ref sMsjError, ref OBj_DAL_TiposClientes);
            }
            

    }

        private void CargarDatos()
        {

            if (OBj_DAL_TiposClientes != null)
            {
                if (OBj_DAL_TiposClientes.CBandAX == 'I')
                {
                    txt_IDTipoCliente.Text = string.Empty;
                    txt_IDTipoCliente.Enabled = true;
                    txt_TipoCliente.Text = string.Empty;
                    txt_TipoCliente.Enabled = true;
                    txt_descripcion.Text = string.Empty;
                    txt_descripcion.Enabled = true;
                    cmb_IDEstado.DataSource = null;
                    cmb_IDEstado.Enabled = true;
                }
                else
                {
                    txt_IDTipoCliente.Text = OBj_DAL_TiposClientes.IIdTipoCliente.ToString().Trim();
                    txt_IDTipoCliente.Enabled = false;
                    txt_TipoCliente.Text = OBj_DAL_TiposClientes.STipoCliente.ToString().Trim();
                    txt_TipoCliente.Enabled = false;
                    txt_descripcion.Text = OBj_DAL_TiposClientes.SDescripcion.ToString().Trim();
                    txt_descripcion.Enabled = false;
                    cmb_IDEstado.Text = OBj_DAL_TiposClientes.CIdEstado.ToString().Trim();
                    cmb_IDEstado.Enabled = false;
                }

            }
            else {
                MessageBox.Show("Se presento un error capa 8 del programador ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }
    }
}