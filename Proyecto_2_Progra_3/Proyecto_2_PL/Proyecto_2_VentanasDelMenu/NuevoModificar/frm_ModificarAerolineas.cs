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
using Proyecto_2_DAL.BaseDatos_DAL;
using Proyecto_2_BLL.Catagolos_Mantinimiento_BLL;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    public partial class frm_ModificarAerolineas : Form
    {
        public cls_Aerolineas_DAL objDAL_Aerolinea = new cls_Aerolineas_DAL();
        public frm_ModificarAerolineas()
        {
            InitializeComponent();
        }

        private void frm_ModificarAerolineas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            cls_BaseDatos_DAL objDAL_BaseDatos = new cls_BaseDatos_DAL();
            if (objDAL_Aerolinea != null)
            {
                if (objDAL_Aerolinea.cBandera == 'I')
                {
                    txt_IdAerolinea.Clear();
                    txt_IdAerolinea.Enabled = true;
                    txt_NombreAerolinea.Clear();
                    cmb_IdEstado.DataSource = objDAL_BaseDatos.DT_Parametros.Columns[2].ToString();
                }
                else
                {
                    txt_IdAerolinea.Text = objDAL_Aerolinea.iIdAerolinea.ToString().Trim();
                    txt_IdAerolinea.Enabled = false;
                    txt_NombreAerolinea.Text = objDAL_Aerolinea.sNombreAerolinea.ToString().Trim();
                    cmb_IdEstado.DataSource = objDAL_BaseDatos.DT_Parametros.Columns[2].ToString();
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
            cls_Aerolineas_BLL objBLL_Aerolineas = new cls_Aerolineas_BLL();
            string sMsjError = string.Empty;
            objDAL_Aerolinea.iIdAerolinea = Convert.ToInt32(txt_IdAerolinea.Text);
            objDAL_Aerolinea.cIdEstado = Convert.ToChar(cmb_IdEstado.SelectedItem.ToString());
            objDAL_Aerolinea.sNombreAerolinea = txt_NombreAerolinea.Text;

            if (objDAL_Aerolinea.cBandera == 'I')
            {
                objBLL_Aerolineas.Insertar_Aerolineas(ref sMsjError, ref objDAL_Aerolinea);
            }
            else
            {
                objBLL_Aerolineas.Modificar_Aerolineas(ref sMsjError, ref objDAL_Aerolinea);
            }
        }

        private void tsb_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_IdAerolinea_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txt_NombreAerolinea_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cmb_IdEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

        }
    }
}
