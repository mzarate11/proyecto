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
            string sMsjError = string.Empty;
            Obj_DAL_Estados.cIdEstado = Convert.ToChar(txt_ID_Estados.Text.Trim());
            Obj_DAL_Estados.sDescripcion = txt_Descripcion.Text.Trim();

            if (Obj_DAL_Estados.cBandAX == 'I')
            {
                cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();

                Obj_Estados_BLL.Insertar_Estados(ref sMsjError, ref Obj_DAL_Estados);

                if (sMsjError == string.Empty)
                {
                    MessageBox.Show("La Base de Datos ha sido Actualizada", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hubo un error al ingresar los datos a la base de datos:" + "[" + sMsjError + "]","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }
    }
}
