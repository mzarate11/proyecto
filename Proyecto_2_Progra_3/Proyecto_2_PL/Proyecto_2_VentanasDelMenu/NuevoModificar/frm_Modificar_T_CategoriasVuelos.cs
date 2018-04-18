﻿using System;
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
    public partial class frm_Modificar_T_CategoriasVuelos : Form
    {
        public cls_T_CategoriasVuelos_DAL Obj_ManteCategorias_DAL;

        public frm_Modificar_T_CategoriasVuelos()
        {
            InitializeComponent();
        }

        #region CargarDatos
        private void CargarDatos()
        {
            #region CargarDatos IdEstados
            cls_Estados_BLL ObjBLLEstados = new cls_Estados_BLL();
            string sMsjError = string.Empty;
            DataTable DTE = new DataTable();
            DTE = ObjBLLEstados.Listar_Estados(ref sMsjError);
            DTE.Rows.Add("0", "--- SELECCIONE UN ESTADO ---");
            cmb_IdEstado.DataSource = DTE;
            cmb_IdEstado.DisplayMember = DTE.Columns[1].ToString();
            cmb_IdEstado.ValueMember = DTE.Columns[0].ToString();
            cmb_IdEstado.SelectedValue = "0";

            #endregion




            if (Obj_ManteCategorias_DAL != null)
            {
                if (Obj_ManteCategorias_DAL.cBandAX == 'I')
                {
                    tb_IdCategoria.Enabled = false;
                    lbiIdCategoria.Enabled = true;
                    tb_DescCategoria.Text = string.Empty;


                }
                else
                {
                    tb_IdCategoria.Text = Obj_ManteCategorias_DAL.iIdCategoria.ToString().Trim();
                    tb_IdCategoria.Enabled = false;
                    tb_DescCategoria.Text = Obj_ManteCategorias_DAL.sDescCategoria.ToString().Trim();
                    cmb_IdEstado.SelectedValue = Obj_ManteCategorias_DAL.cIdEstado.ToString().Trim();
                                          

                 
                }

            }
            else
            {
                MessageBox.Show("Se presentó un error de capa 8 de programador. \n\nFavor Contactar a soporte técnico", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        #endregion

        #region Load
        private void frm_Modificar_T_CategoriasVuelos_Load_1(object sender, EventArgs e)
        {
            CargarDatos();
        }
        #endregion

        #region Boton Salir
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Boton Guardar
        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            cls_T_CategoriasVuelos_BLL Obj_CategoriaVuelos_BLL = new cls_T_CategoriasVuelos_BLL();
            if (tb_DescCategoria.Text == "" || cmb_IdEstado.Text == "--- SELECCIONE UN ESTADO ---")
            {
                MessageBox.Show("Alguno de lo campos esta vacido favor de verificar", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string sMsjError = string.Empty;
                Obj_ManteCategorias_DAL.sDescCategoria = tb_DescCategoria.Text;
                Obj_ManteCategorias_DAL.cIdEstado = Convert.ToChar(cmb_IdEstado.SelectedValue);
                if (Obj_ManteCategorias_DAL.cBandAX == 'I')
                {


                    Obj_CategoriaVuelos_BLL.Insertar_CategoriaVuelos(ref sMsjError, ref Obj_ManteCategorias_DAL);

                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("La Base de Datos ha sido Actualizada", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tb_IdCategoria.Text = Obj_ManteCategorias_DAL.iIdCategoria.ToString();
                        Obj_ManteCategorias_DAL.cBandAX = 'U';
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al ingresar los datos a la base de datos:" + "[" + sMsjError + "]", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Obj_CategoriaVuelos_BLL.Modificar_Estados(ref sMsjError, ref Obj_ManteCategorias_DAL);
                    if (sMsjError == string.Empty)
                    {
                        MessageBox.Show("Categoría Modificado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show(sMsjError.ToString());
                    }
                }
            }
        }
        #endregion

        #region Validaciones Caja de texto
        private void tb_IdCategoria_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo permite letras", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void tb_DescCategoria_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.Equals(' ')) && (tb_DescCategoria.Text == ""))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten campos vasidos al inicio", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (e.KeyChar.Equals(' '))
                {
                    e.Handled = false;
                }
                else
                {
                    if (char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back))
                    {
                        e.Handled = false;



                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("Este campo solo permite letras", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }

        }
        #endregion

        private void cmb_IdEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Este campo no se puede editar ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        }
}
