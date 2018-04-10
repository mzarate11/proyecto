﻿using System;
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

        private void frm_ModificarAviones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
        private void CargarDatos()
        {
            cls_BaseDatos_DAL objDAL_BaseDatos = new cls_BaseDatos_DAL();
            if (objDal_Aviones != null)
            {
                #region Combo Estados
                cls_Estados_BLL ObjBLLEstados = new cls_Estados_BLL();
                string sMsjError = string.Empty;

                DataTable DTE = new DataTable();
                DTE = ObjBLLEstados.Listar_Estados(ref sMsjError);

                DTE.Rows.Add("0", "--Seleccione una opcion--");

                cmb_IdEstado.DataSource = DTE;
                cmb_IdEstado.DisplayMember = DTE.Columns[1].ToString();
                cmb_IdEstado.ValueMember = DTE.Columns[0].ToString();

                cmb_IdEstado.SelectedValue = "0";
                #endregion

                #region Combo Aero
                cls_Aerolineas_BLL ObjAero = new cls_Aerolineas_BLL();
                DataTable DTA = new DataTable();
                DTA = ObjAero.ListarAerolineas(ref sMsjError);
                DTA.Rows.Add("0", "--Seleccione una opcion--");
                cmb_IdAerolinea.DataSource = DTA;
                cmb_IdAerolinea.DisplayMember = DTA.Columns[1].ToString();
                cmb_IdAerolinea.ValueMember = DTA.Columns[0].ToString();
                cmb_IdAerolinea.SelectedValue = "0";
                #endregion
                
                #region Combo TipoA
                cls_TiposA_BLL ObjTiposA = new cls_TiposA_BLL();
                DataTable DTTA = new DataTable();
                DTTA = ObjTiposA.ListarTiposA(ref sMsjError);
                DTTA.Rows.Add("0", "--Seleccione una opcion--");
                cmb_IdTipoAvion.DataSource = DTTA;
                cmb_IdTipoAvion.DisplayMember = DTTA.Columns[1].ToString();
                cmb_IdTipoAvion.ValueMember = DTTA.Columns[0].ToString();
                cmb_IdTipoAvion.SelectedValue = "0";
                #endregion

                if (objDal_Aviones.cBandera == 'I')
                {
                    txt_IdAvion.Clear();
                    txt_DescAvion.Clear();
                    txt_NomAvion.Clear();
                    txt_IdAvion.Enabled = true;                
                }
                else
                {
                    txt_DescAvion.Text = objDal_Aviones.sDescAvion;
                    txt_IdAvion.Text = objDal_Aviones.sIdAvion;
                    txt_NomAvion.Text = objDal_Aviones.sNomAvion;
                    cmb_IdAerolinea.SelectedValue = objDal_Aviones.iIdAerolinea.ToString();
                    cmb_IdEstado.SelectedValue = objDal_Aviones.cIdEstado.ToString();
                    cmb_IdTipoAvion.SelectedValue = objDal_Aviones.sIdTipoAvion.ToString();
                    txt_IdAvion.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Se presento un capa 8 del programador");
                Close();
            }
        }

        private void txt_IdAvion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)(Keys.Back) || e.KeyChar == (char)(Keys.Space) || e.KeyChar == '-')
            {
                if(e.KeyChar == '-')
                {
                    if (txt_IdAvion.Text.Contains("-"))
                    {
                        e.Handled = true;
                    }
                    else if(txt_IdAvion.SelectionStart != 1 && e.KeyChar == '-')
                    {
                        if (txt_IdAvion.SelectionStart == 2 && e.KeyChar == '-')
                        {
                            e.Handled = false;
                        }
                        else
                        {
                            e.Handled = true;
                        }                                            
                    }                    
                }
                else
                {
                    e.Handled = false;
                }
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back) || e.KeyChar == (char)(Keys.Space))
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
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)(Keys.Back) || e.KeyChar == (char)(Keys.Space))
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (cmb_IdEstado.SelectedValue.ToString() != "0" ||
                cmb_IdAerolinea.SelectedValue.ToString() != "0" ||
                cmb_IdTipoAvion.SelectedValue.ToString() != "0" ||
                txt_NomAvion.Text != string.Empty || txt_IdAvion.Text != string.Empty || txt_DescAvion.Text != string.Empty)
            {
                cls_Aviones_BLL objBLL_Aviones = new cls_Aviones_BLL();
                string sMsjError = string.Empty;                
                objDal_Aviones.sNomAvion = txt_NomAvion.Text;
                objDal_Aviones.sDescAvion = txt_DescAvion.Text;
                objDal_Aviones.sIdAvion = txt_IdAvion.Text;
                objDal_Aviones.sIdTipoAvion = cmb_IdTipoAvion.SelectedValue.ToString();
                objDal_Aviones.iIdAerolinea = Convert.ToInt32(cmb_IdAerolinea.SelectedValue.ToString().Trim());
                objDal_Aviones.cIdEstado = Convert.ToChar(cmb_IdEstado.SelectedValue.ToString());

                if (objDal_Aviones.cBandera == 'I')
                {
                    objBLL_Aviones.Insertar_Aviones(ref sMsjError, ref objDal_Aviones);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se guardó el nuevo registro exitosamente");
                        objDal_Aviones.cBandera = 'U';
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error al tratar de guardar el registro");
                    }
                }
                else
                {
                    objBLL_Aviones.Modificar_Aviones(ref sMsjError, ref objDal_Aviones);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Se modificó el nuevo registro exitosamente");
                        objDal_Aviones.cBandera = 'U';
                    }
                    else
                    {
                        MessageBox.Show("Se presentó un error al tratar de modificar el registro");
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
