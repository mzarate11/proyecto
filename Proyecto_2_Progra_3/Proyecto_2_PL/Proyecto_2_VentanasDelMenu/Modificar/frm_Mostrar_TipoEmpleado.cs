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

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.Modificar
{
    public partial class frm_Mostrar_TipoEmpleado : Form
    {
        public cls_TipoEmpleados_DAL Obj_DAL_TipoEmpleado;
        public frm_Mostrar_TipoEmpleado()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            cls_TiposEmpleados_BLL obj_TipoEmpleado_BLL = new cls_TiposEmpleados_BLL();
            string sMsjError = string.Empty;
            Obj_DAL_TipoEmpleado.ITipoEmpleado = Convert.ToInt32(txt_IDTipoEmpleado.Text.Trim());
            Obj_DAL_TipoEmpleado.SDescTipo = txt_DescTipo.Text.Trim();
            Obj_DAL_TipoEmpleado.CIdEstado = Convert.ToChar(cmb_IDEstado.Text.Trim());

            if (Obj_DAL_TipoEmpleado.CBandAX == 'I')
            {
                obj_TipoEmpleado_BLL.Insertar_TipoEmpleado(ref sMsjError, ref Obj_DAL_TipoEmpleado);
            }
            else
            {
                obj_TipoEmpleado_BLL.Modificat_TipoEmpleado(ref sMsjError, ref Obj_DAL_TipoEmpleado);
            }

        }

        private void CargarDatos()
        {
            if (Obj_DAL_TipoEmpleado != null)
            {
                if (Obj_DAL_TipoEmpleado.CBandAX == 'I')
                {
                    txt_IDTipoEmpleado.Text = string.Empty;
                    txt_IDTipoEmpleado.Enabled = true;
                    txt_DescTipo.Text = string.Empty;
                    txt_DescTipo.Enabled = true;
                    cmb_IDEstado.DataSource = null;
                    cmb_IDEstado.Enabled = true;
                }
                else
                {
                    txt_IDTipoEmpleado.Text = Obj_DAL_TipoEmpleado.ITipoEmpleado.ToString().Trim();
                    txt_IDTipoEmpleado.Enabled = false;
                    txt_DescTipo.Text = Obj_DAL_TipoEmpleado.SDescTipo.ToString().Trim();
                    txt_DescTipo.Enabled = false;
                    cmb_IDEstado.Text = Obj_DAL_TipoEmpleado.SDescTipo.ToString().Trim();
                    cmb_IDEstado.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Se presento un error capa8", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
