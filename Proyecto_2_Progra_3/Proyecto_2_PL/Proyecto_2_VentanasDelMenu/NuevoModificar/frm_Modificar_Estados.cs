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

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    public partial class frm_Modificar_Estados : Form
    {
        public cls_Estados_DAL Obj_DAL_Estados;
        public frm_Modificar_Estados()
        {
            InitializeComponent();
        }

        private void CargarDatos()
        {
            if (Obj_DAL_Estados != null)
            {
                if (Obj_DAL_Estados.cBandAX == 'I')
                {
                    txt_ID_Estados.Text = string.Empty;
                    txt_ID_Estados.Enabled = true;
                    txt_Descripcion.Text = string.Empty;
                }
                else
                {
                    txt_ID_Estados.Text = Obj_DAL_Estados.cIdEstado.ToString().Trim();
                    txt_ID_Estados.Enabled = false;
                    txt_Descripcion.Text = Obj_DAL_Estados.sDescripcion.Trim();
                }
            }
            else
            {
                MessageBox.Show("Se presentó un error de capa 8 de programador. \n\nFavor Contactar a soporte técnico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }
        private void frm_Mostrar_Estados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (char.IsPunctuation(e.KeyChar)) || (char.IsSeparator(e.KeyChar))||(char.IsSymbol(e.KeyChar)))
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Obj_DAL_Estados.cIdEstado = Convert.ToChar(txt_ID_Estados.Text);
            Obj_DAL_Estados.sDescripcion = txt_Descripcion.Text;

            if (Obj_DAL_Estados.cBandAX == 'I')
            {

            }
            else
            {

            }
        }
    }
}
