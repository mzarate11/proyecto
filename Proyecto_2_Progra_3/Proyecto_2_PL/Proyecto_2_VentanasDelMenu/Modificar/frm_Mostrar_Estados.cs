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
using Proyecto_2_DAL;
using Proyecto_2_BLL.Catagolos_Mantinimiento_BLL;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.Modificar
{
    public partial class frm_Mostrar_Estados : Form
    {
        #region Global
        public cls_Estados_DAL Obj_DAL_Estados;

        #endregion


        public frm_Mostrar_Estados()
        {
            InitializeComponent();
        }

        private void frm_Mostrar_Estados_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            if (Obj_DAL_Estados != null)
            {
                if (Obj_DAL_Estados.cBandAX == 'I')
                {
                    txt_ID.Text = string.Empty;
                    txt_ID.Enabled = true;
                    txt_Descripcion.Text = string.Empty;
                }
                else
                {
                    txt_ID.Text = Obj_DAL_Estados.cIdEstado.ToString().Trim();
                    txt_ID.Enabled = false;
                    txt_Descripcion.Text = Obj_DAL_Estados.sDescripcion.Trim();
                }
            }
            else
            {
                MessageBox.Show("Se presentó un error de capa 8 de programador. \n\nFavor Contactar a soporte técnico","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void txt_Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls_Estados_BLL Obj_Estados_BLL = new cls_Estados_BLL();
            string sMsjError = string.Empty;
            Obj_DAL_Estados.cIdEstado = Convert.ToChar(txt_ID.Text.Trim());
            Obj_DAL_Estados.sDescripcion = txt_Descripcion.Text.Trim();

            if (Obj_DAL_Estados.cBandAX == 'I')
            {
                Obj_Estados_BLL.Insertar_Estados(ref sMsjError, ref Obj_DAL_Estados);
            }
            else
            {
                Obj_Estados_BLL.Modificar_Estados(ref sMsjError, ref Obj_DAL_Estados);
            }
        }
    }
}
