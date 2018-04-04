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
                #region Combo Estados
                cls_Estados_BLL ObjBLLEstados = new cls_Estados_BLL();
                string sMsjError = string.Empty;
                DataTable DTE = new DataTable();
                DTE = ObjBLLEstados.Listar_Estados(ref sMsjError);
                DTE.Rows.Add("0", "-- SELECCIONE UN ESTADO");
                cmb_IdEstado.DataSource = DTE;
                cmb_IdEstado.DisplayMember = DTE.Columns[1].ToString();
                cmb_IdEstado.ValueMember = DTE.Columns[0].ToString();
                cmb_IdEstado.SelectedValue = "0";
                #endregion

                if (objDAL_Aerolinea.cBandera == 'I')
                {
                    txt_IdAerolinea.Clear();
                    txt_IdAerolinea.Enabled = true;
                    txt_NombreAerolinea.Clear();
                   
                }
                else
                {
                    txt_IdAerolinea.Text = objDAL_Aerolinea.iIdAerolinea.ToString().Trim();
                    txt_IdAerolinea.Enabled = false;
                    txt_NombreAerolinea.Text = objDAL_Aerolinea.sNombreAerolinea.ToString().Trim();
                    
                }
            }
            else
            {

                MessageBox.Show("Se presento un capa 8 del programador");
                Close();
            }
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_IdEstado.SelectedValue.ToString() != "0" ||
                txt_IdAerolinea.Text != string.Empty || txt_NombreAerolinea.Text != string.Empty)
            {
                cls_Aerolineas_BLL objBLL_Aerolineas = new cls_Aerolineas_BLL();
                string sMsjError = string.Empty;
                objDAL_Aerolinea.iIdAerolinea = Convert.ToInt32(txt_IdAerolinea.Text);
                objDAL_Aerolinea.cIdEstado = Convert.ToChar(cmb_IdEstado.SelectedValue.ToString());
                objDAL_Aerolinea.sNombreAerolinea = txt_NombreAerolinea.Text;

                if (objDAL_Aerolinea.cBandera == 'I')
                {
                    objBLL_Aerolineas.Insertar_Aerolineas(ref sMsjError, ref objDAL_Aerolinea);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se guardó el nuevo registro exitosamente");
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error");
                    }
                }
                else
                {
                    objBLL_Aerolineas.Modificar_Aerolineas(ref sMsjError, ref objDAL_Aerolinea);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se modificó el nuevo registro exitosamente");
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

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
