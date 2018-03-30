using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;
using Proyecto_2_BLL.Catagolos_Mantinimiento_BLL;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    public partial class frm_ModificarNuevo_TipoAvion : Form
    {
        public cls_TipoAviones_DAL Obj_Mant_DAL;
        public frm_ModificarNuevo_TipoAvion()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string sSeparadorDecimal = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToString().Trim();

        private bool validaciones()
        {
            if(txt_IdTipoAvion.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar un ID del Tipo de Avion","Eror en Datos",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_IdTipoAvion.SelectAll();
                txt_IdTipoAvion.Focus();
            }
            else if (txt_NombreAvion.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar un nombre del Tipo de Avion", "Eror en Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NombreAvion.SelectAll();
                txt_NombreAvion.Focus();
            }
            else if (txt_CantidadPasajeros.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar cantidad de pasajeros", "Eror en Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CantidadPasajeros.SelectAll();
                txt_CantidadPasajeros.Focus();
            }
            else if(txt_CantidadPeso.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar un peso", "Eror en Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_CantidadPeso.SelectAll();
                txt_CantidadPeso.Focus();
            }
            else if(cmb_IdEstado.Text == string.Empty)
            {
                MessageBox.Show("Debe digitar ID estado", "Eror en Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txt_CantidadPeso.Text.Contains(Convert.ToChar(sSeparadorDecimal)))
                {
                    if(txt_CantidadPeso.Text.IndexOf(Convert.ToChar(sSeparadorDecimal)) < txt_CantidadPeso.Text.Length-3)
                    {
                        MessageBox.Show("El peso es incorrecto, solo se permiten dos decimales en este apartado", "Eror en Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txt_CantidadPeso.SelectAll();
                        txt_CantidadPeso.Focus();
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                }
                else
                {
                    return true;
                }
            }
            return false;      
        }

        private void guardarDatos()
        {
            cls_TiposA_BLL ObjTipoAviones_BLL = new cls_TiposA_BLL();
            string sMsjError = string.Empty;

            Obj_Mant_DAL.iCapacidadPasajeros = Convert.ToInt16(txt_CantidadPasajeros.Text);
            Obj_Mant_DAL.dcapacidadPeso = Convert.ToDouble(txt_CantidadPeso.Text);
            Obj_Mant_DAL.sDescTipoAvion = txt_Descripcion.Text;
            Obj_Mant_DAL.sIdTipoAvion = txt_IdTipoAvion.Text;
            Obj_Mant_DAL.sNombreTipoAvion = txt_NombreAvion.Text;
            Obj_Mant_DAL.cIdEstado = Convert.ToChar(cmb_IdEstado.Text);

            if (Obj_Mant_DAL.cbanderaAccion == 'I')
            {
                ObjTipoAviones_BLL.AgregarTipoAviones(ref sMsjError, ref Obj_Mant_DAL);
            }
            else
            {
                ObjTipoAviones_BLL.ModificarTipoAviones(ref sMsjError, ref Obj_Mant_DAL);
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones())
            {
                guardarDatos();
            }
            else
            {
                MessageBox.Show("No se pudo completar la acción","Eror en la acción",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void frm_ModificarNuevo_TipoAvion_Load(object sender, EventArgs e)
        {
            cmb_IdEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_IdEstado.Enabled = true;
            cargarDatos();
        }

        private void txt_CantidadPasajeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_IdTipoAvion_TextChanged(object sender, EventArgs e)
        {
            txt_IdTipoAvion.Text = txt_IdTipoAvion.Text.ToUpper();
            txt_IdTipoAvion.SelectionStart = txt_IdTipoAvion.Text.Length;
        }

        private void txt_CantidadPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsNumber(e.KeyChar)))
            {
                if (txt_CantidadPeso.Text.Contains(Convert.ToChar(sSeparadorDecimal)))
                {
                    if (txt_CantidadPeso.Text.IndexOf(Convert.ToChar(sSeparadorDecimal)) == txt_CantidadPeso.Text.Length - 3)
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = false;
                    }
                }
                else
                {
                    e.Handled = false;
                }
                
            }
            else if(e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                if((e.KeyChar == Convert.ToChar(sSeparadorDecimal)))
                {
                    if (txt_CantidadPeso.Text.Contains(Convert.ToChar(sSeparadorDecimal)))
                    {
                        e.Handled = true;
                    }
                    else
                    {
                        if(txt_CantidadPeso.SelectionStart == 0)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            if(txt_CantidadPeso.SelectionStart == 6)
                            {
                                e.Handled = true;
                            }
                            else
                            {
                                e.Handled = false;   
                            }
                                
                        }
                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void cargarDatos()
        {
            if (Obj_Mant_DAL != null)
            {
                if (Obj_Mant_DAL.cbanderaAccion == 'I')
                {
                    //limpiar cajas de texto
                    txt_IdTipoAvion.Enabled = true;
                    txt_CantidadPasajeros.Clear();
                    txt_CantidadPeso.Clear();
                    txt_Descripcion.Clear();
                    txt_IdTipoAvion.Clear();
                    txt_NombreAvion.Clear();
                }
                else
                {
                    txt_IdTipoAvion.Enabled = false;
                    txt_CantidadPasajeros.Text = Obj_Mant_DAL.iCapacidadPasajeros.ToString().Trim();
                    txt_CantidadPeso.Text = Obj_Mant_DAL.dcapacidadPeso.ToString().Trim();
                    txt_Descripcion.Text = Obj_Mant_DAL.sDescTipoAvion.ToString().Trim();
                    txt_IdTipoAvion.Text = Obj_Mant_DAL.sIdTipoAvion.ToString().Trim();
                    txt_NombreAvion.Text = Obj_Mant_DAL.sNombreTipoAvion.ToString().Trim();
                    cmb_IdEstado.Text = Obj_Mant_DAL.cIdEstado.ToString().Trim();

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
