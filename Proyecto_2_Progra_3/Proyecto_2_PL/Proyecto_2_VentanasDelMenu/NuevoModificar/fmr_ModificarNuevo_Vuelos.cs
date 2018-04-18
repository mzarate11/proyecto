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
            //FORMATO DE FECHA INTERNACIONAL DEFINIDO POR LA ISO
            time_HoraLlegada.Format = DateTimePickerFormat.Custom;
            time_HoraLlegada.CustomFormat = "yyy-MMM-dd hh:mm tt";

            time_HoraSalida.Format = DateTimePickerFormat.Custom;
            time_HoraSalida.CustomFormat = "yyy-MMM-dd hh:mm tt";

            cmb_IdAerolinea.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_IdDestino.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_IdEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_IdAvion.DropDownStyle = ComboBoxStyle.DropDownList;

            cargarDatos();
            txt_IdVuelo.SelectAll();
            txt_IdVuelo.Focus();

            if(Obj_Mant_DAL.cbanderaAccion == 'I')
            {
                labelAccion.Text = "Guardar";
            }
            else
            {
                labelAccion.Text = "Modificar";
            }

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
                Obj_Mant_DAL.sIdVuelo = txt_IdVuelo.Text;
                Obj_Mant_DAL.sIdDestino = cmb_IdDestino.SelectedValue.ToString();
                Obj_Mant_DAL.sIdAvion = cmb_IdAvion.SelectedValue.ToString();
                Obj_Mant_DAL.iIdAerolinea = Convert.ToInt16(cmb_IdAerolinea.SelectedValue.ToString());
                Obj_Mant_DAL.cIdEstado = Convert.ToChar(cmb_IdEstado.SelectedValue.ToString());
                Obj_Mant_DAL.dtFechaHoraSalida = time_HoraSalida.Value;
                Obj_Mant_DAL.dtFechaHoraLLegada = time_HoraLlegada.Value;
                cls_Vuelos_BLL Obj_Mant_BLL = new cls_Vuelos_BLL();
                string sMsjError = string.Empty;

                if (Obj_Mant_DAL.cbanderaAccion == 'I')
                {
                    Obj_Mant_BLL.AgregarVuelos(ref sMsjError, ref Obj_Mant_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Vuelo agregado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        labelAccion.Text = "Modificar";

                    }
                    else
                    {
                        MessageBox.Show(sMsjError.ToString());
                        labelAccion.Text = "Guardar";
                    }
                }
                else
                {
                    Obj_Mant_BLL.ModificarVuelos(ref sMsjError, ref Obj_Mant_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Vuelo Modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(sMsjError.ToString());
                    }
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
                #region CargarDatos IdDestino
                cls_Destinos_BLL ObjBLLDestinos = new cls_Destinos_BLL();
                string sMsjErrorDEestido = string.Empty;
                DataTable DTEDestino = new DataTable();
                DTEDestino = ObjBLLDestinos.ListarDestinos(ref sMsjErrorDEestido);
                DTEDestino.Rows.Add("0",1, "-- SELECCIONE UN DESTINO --", 2,3,'a');
                cmb_IdDestino.DataSource = DTEDestino;
                cmb_IdDestino.DisplayMember = DTEDestino.Columns[2].ToString();
                cmb_IdDestino.ValueMember = DTEDestino.Columns[0].ToString();
                cmb_IdDestino.SelectedValue = "0";

                #endregion

                #region CargarDatos IdAerolinea
                cls_Aerolineas_BLL ObjBLLAerolinea = new cls_Aerolineas_BLL();
                string sMsjErrorAerolinea = string.Empty;
                DataTable DTEAerolinea = new DataTable();
                DTEAerolinea = ObjBLLAerolinea.ListarAerolineas(ref sMsjErrorAerolinea);
                DTEAerolinea.Rows.Add("0", "-- SELECCIONE UNA AEROLINEA --", 'a');
                cmb_IdAerolinea.DataSource = DTEAerolinea;
                cmb_IdAerolinea.DisplayMember = DTEAerolinea.Columns[1].ToString();
                cmb_IdAerolinea.ValueMember = DTEAerolinea.Columns[0].ToString();
                cmb_IdAerolinea.SelectedValue = "0";
                #endregion


                #region CargarDatos IdAvion
                cls_Aviones_BLL ObjBLLAvion = new cls_Aviones_BLL();
                string sMsjErrorAvion = string.Empty;
                DataTable DTEAvion = new DataTable();
                DTEAvion = ObjBLLAvion.ListarAvion(ref sMsjErrorAvion);
                DTEAvion.Rows.Add("0", "-- SELECCIONE UN AVION --","0",0,"0",'a');
                cmb_IdAvion.DataSource = DTEAvion;
                cmb_IdAvion.DisplayMember = DTEAvion.Columns[1].ToString();
                cmb_IdAvion.ValueMember = DTEAvion.Columns[0].ToString();
                cmb_IdAvion.SelectedValue = "0";
                #endregion

                #region CargarDatos IdEstados
                cls_Estados_BLL ObjBLLEstados = new cls_Estados_BLL();
                string sMsjError = string.Empty;
                DataTable DTE = new DataTable();
                DTE = ObjBLLEstados.Listar_Estados(ref sMsjError);
                DTE.Rows.Add("0", "-- SELECCIONE UN ESTADO --");
                cmb_IdEstado.DataSource = DTE;
                cmb_IdEstado.DisplayMember = DTE.Columns[1].ToString();
                cmb_IdEstado.ValueMember = DTE.Columns[0].ToString();
                cmb_IdEstado.SelectedValue = "0";

                #endregion

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
