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
    public partial class fmr_ModificarNuevo_Vuelos : Form
    {

        public cls_Vuelos_DAL Obj_Mant_DAL;
        public fmr_ModificarNuevo_Vuelos()
        {
            InitializeComponent();
        }

        private void fmr_ModificarNuevo_Vuelos_Load(object sender, EventArgs e)
        {
            time_HoraLlegada.Format = DateTimePickerFormat.Custom;
            time_HoraLlegada.CustomFormat = "dd-MMM-yyy hh:mm tt";

            time_HoraSalida.Format = DateTimePickerFormat.Custom;
            time_HoraSalida.CustomFormat = "dd-MMM-yyy hh:mm tt";

            cmb_IdAerolinea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_IdDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_IdEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_IdAvion.DropDownStyle = ComboBoxStyle.DropDownList;

            cargarDatos();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_IdVuelo_TextChanged(object sender, EventArgs e)
        {
            txt_IdVuelo.Text = txt_IdVuelo.Text.ToUpper();
            txt_IdVuelo.SelectionStart = txt_IdVuelo.Text.Length;
        }

        private bool validaciones()
        {
            if (txt_IdVuelo.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar un un Id del Vuelo", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_IdVuelo.SelectAll();
                txt_IdVuelo.Focus();
            }
            else if (cmb_IdAerolinea.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un ID Aerolinea", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmb_IdAvion.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un ID Avión", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmb_IdDestino.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un ID Destino", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cmb_IdEstado.Text == string.Empty)
            {
                MessageBox.Show("Debe seleccionar un ID Estado", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(time_HoraLlegada.Value <= time_HoraSalida.Value)
            {
                MessageBox.Show("Error en las fechas, la fecha de llegada debe ser mayor a la fehca de salida", "Error en datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return true;
            }
            return false;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                cls_Vuelos_BLL Obj_Mant_BLL = new cls_Vuelos_BLL();
                string sMsjError = string.Empty;
                if (Obj_Mant_DAL.cbanderaAccion == 'I')
                {
                    Obj_Mant_BLL.AgregarVuelos(ref sMsjError, ref Obj_Mant_DAL);
                }
                else
                {
                    Obj_Mant_BLL.ModificarVuelos(ref sMsjError, ref Obj_Mant_DAL);
                }
            }
            else
            {
                MessageBox.Show("No se pudo completar la acción", "Eror en la acción", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cargarDatos()
        {
            if (Obj_Mant_DAL != null)
            {
                if (Obj_Mant_DAL.cbanderaAccion == 'I')
                {
                    txt_IdVuelo.Enabled = true;
                    txt_IdVuelo.SelectAll();
                    txt_IdVuelo.Focus();
                }
                else
                {
                    txt_IdVuelo.Enabled = false;
                    txt_IdVuelo.Text = Obj_Mant_DAL.sIdVuelo.ToString().Trim();

                }

            }
            else
            {
                MessageBox.Show("Se presentó un error, contacte a soporte", "Error datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }


    }
}
