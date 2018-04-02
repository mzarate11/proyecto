using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_2_DAL.BaseDatos_DAL;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;
using Proyecto_2_BLL.Catagolos_Mantinimiento_BLL;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    public partial class frm_ModificarAviones : Form
    {
        public cls_Aviones_DAL objDal_Aviones = new cls_Aviones_DAL();
        public frm_ModificarAviones()
        {
            InitializeComponent();
        }

        private void lbl_DescAvion_Click(object sender, EventArgs e)
        {

        }

        private void frm_ModificarAviones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            cls_BaseDatos_DAL objDAL_BaseDatos = new cls_BaseDatos_DAL();
            if (objDal_Aviones != null)
            {
                if (objDal_Aviones.cBandera == 'I')
                {
                    txt_IdAvion.Clear();
                    txt_DescAvion.Clear();
                    txt_NomAvion.Clear();
                    cmb_IdAerolinea.DisplayMember = objDAL_BaseDatos.DT_Parametros.Columns[3].ToString();
                    cmb_IdTipoAvion.DisplayMember = objDAL_BaseDatos.DT_Parametros.Columns[4].ToString();
                    cmb_IdEstado.DisplayMember = objDAL_BaseDatos.DT_Parametros.Columns[5].ToString();
                    txt_IdAvion.Enabled = true;
                }
                else
                {
                    txt_DescAvion.Text = objDal_Aviones.sDescAvion;
                    txt_IdAvion.Text = objDal_Aviones.sIdAvion;
                    txt_NomAvion.Text = objDal_Aviones.sNomAvion;
                    cmb_IdAerolinea.DisplayMember = objDAL_BaseDatos.DT_Parametros.Columns[3].ToString();
                    cmb_IdTipoAvion.DisplayMember = objDAL_BaseDatos.DT_Parametros.Columns[4].ToString();
                    cmb_IdEstado.DisplayMember = objDAL_BaseDatos.DT_Parametros.Columns[5].ToString();
                    txt_IdAvion.Enabled = false;
                }
            }
            else
            {

                MessageBox.Show("Se presento un capa 8 del programador");
                Close();
            }
        }

        private void tsb_Guardar_Click(object sender, EventArgs e)
        {
            cls_Aviones_BLL objBLL_Aviones = new cls_Aviones_BLL();
            string sMsjError = string.Empty;
            objDal_Aviones.iIdAerolinea = Convert.ToInt32(cmb_IdAerolinea.SelectedItem.ToString());
            objDal_Aviones.cIdEstado = Convert.ToChar(cmb_IdEstado.SelectedItem.ToString());
            objDal_Aviones.sNomAvion = txt_NomAvion.Text;
            objDal_Aviones.sDescAvion = txt_DescAvion.Text;
            objDal_Aviones.sIdAvion = txt_IdAvion.Text;
            objDal_Aviones.sIdTipoAvion = cmb_IdTipoAvion.SelectedItem.ToString();

            if (objDal_Aviones.cBandera == 'I')
            {
                objBLL_Aviones.Insertar_Aviones(ref sMsjError, ref objDal_Aviones);
            }
            else
            {
                objBLL_Aviones.Modificar_Aviones(ref sMsjError, ref objDal_Aviones);
            }
        }

        private void txt_IdAvion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
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

        private void txt_NomAvion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
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

        private void txt_DescAvion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back))
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

        private void tsb_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmb_IdAerolinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_IdTipoAvion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmb_IdEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
