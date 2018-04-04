using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_2_BLL.Catagolos_Mantinimiento_BLL;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;
using Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu
{
    public partial class frm_Empleados : Form
    {
        public frm_Empleados()
        {
            InitializeComponent();
        }
        cls_Empleados_DAL Obj_Empleados_DAL;

        private void frm_Empleados_Load(object sender, EventArgs e)
        {
            Cargar();
        }

      
        private void Cargar()
        {
            cls_Empleados_BLL ObjBLL = new cls_Empleados_BLL();
            string M_Error = string.Empty;
            DataTable DT = new DataTable();
            if (tls_txt_Filtro.Text == string.Empty)
            {
                DT = ObjBLL.Listar_Empleados(ref M_Error);
            }
            else
            {
                DT = ObjBLL.Filtrar_Empleados(ref M_Error, tls_txt_Filtro.Text.Trim());
            }

            if (M_Error == string.Empty)
            {
                dgv_Empleados.DataSource = null;
                dgv_Empleados.DataSource = DT;
            }
            else
            {
                dgv_Empleados.DataSource = null;

                MessageBox.Show("Se presentó un error a la hora de listar los empleados.\n\nDetalle Error : " + M_Error,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tls_btn_Refrescar_Click(object sender, EventArgs e)
        {
            tls_txt_Filtro.Text = string.Empty;
            Cargar();
        }

        private void tls_txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            Cargar();
        }

        private void tls_btn_Eliminar_Click(object sender, EventArgs e)
        {
            cls_Empleados_BLL objBLL = new cls_Empleados_BLL();
            string sMsjError = string.Empty;

            if (dgv_Empleados.Rows.Count > 0)
            {
                if (MessageBox.Show("Realmente desea eliminar?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    objBLL.Eliminar_Empleados(ref sMsjError, dgv_Empleados.SelectedRows[0].Cells[0].Value.ToString());

                    if (sMsjError != string.Empty)
                    {
                        MessageBox.Show("Se presento un error a la hora de listar : [ " + sMsjError + " ]", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Registro eliminado correctamente", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Cargar();
                    }
                    tls_txt_Filtro.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("No hay registros para eliminar");
            }
        }

        private void tls_btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tls_btn_Nuevo_Click(object sender, EventArgs e)
        {
            frm_Modificar_Empleados NuevoEmpleado = new frm_Modificar_Empleados();
            Obj_Empleados_DAL = new cls_Empleados_DAL();

            Obj_Empleados_DAL.cBandera = 'I';
            Obj_Empleados_DAL.sNombre = string.Empty;
            Obj_Empleados_DAL.sApellidos = string.Empty;
            Obj_Empleados_DAL.sDireccion = string.Empty;
            Obj_Empleados_DAL.bEdad = 0;
            Obj_Empleados_DAL.dSalario = 0;
            Obj_Empleados_DAL.iTelCasa = 0;
            Obj_Empleados_DAL.iTelRef = 0;
            Obj_Empleados_DAL.iCelular = 0;
            Obj_Empleados_DAL.iCedula = 0;
            Obj_Empleados_DAL.iIdAerolinea = 0;
            Obj_Empleados_DAL.iIdTipoEmpleado = 0;
            Obj_Empleados_DAL.uIdEmpleado = 0;
            Obj_Empleados_DAL.cIdEstado = ' ';

            NuevoEmpleado.Obj_Empleados_DAL = Obj_Empleados_DAL;
            NuevoEmpleado.ShowDialog();
            Show();
            this.Hide();

            tls_txt_Filtro.Text = string.Empty;
            Cargar();
        }

        private void tls_btn_Modificar_Click(object sender, EventArgs e)
        {
            frm_Modificar_Empleados ModificarEmpleado = new frm_Modificar_Empleados();
            if (dgv_Empleados.RowCount > 0)
            {
                Obj_Empleados_DAL = new cls_Empleados_DAL();

                Obj_Empleados_DAL.cBandera = 'U';
                Obj_Empleados_DAL.uIdEmpleado = Convert.ToUInt16(dgv_Empleados.SelectedRows[0].Cells[0].Value.ToString().Trim());
                Obj_Empleados_DAL.iCedula = Convert.ToInt32(dgv_Empleados.SelectedRows[0].Cells[1].Value.ToString().Trim());
                Obj_Empleados_DAL.sNombre = dgv_Empleados.SelectedRows[0].Cells[2].Value.ToString();
                Obj_Empleados_DAL.sApellidos = dgv_Empleados.SelectedRows[0].Cells[3].Value.ToString();
                Obj_Empleados_DAL.sDireccion = dgv_Empleados.SelectedRows[0].Cells[4].Value.ToString();
                Obj_Empleados_DAL.bEdad = Convert.ToByte(dgv_Empleados.SelectedRows[0].Cells[5].Value.ToString().Trim());
                Obj_Empleados_DAL.iTelCasa = Convert.ToInt32(dgv_Empleados.SelectedRows[0].Cells[6].Value.ToString().Trim());
                Obj_Empleados_DAL.iTelRef = Convert.ToInt32(dgv_Empleados.SelectedRows[0].Cells[7].Value.ToString().Trim());
                Obj_Empleados_DAL.iCelular = Convert.ToInt32(dgv_Empleados.SelectedRows[0].Cells[8].Value.ToString().Trim());
                Obj_Empleados_DAL.dSalario = Convert.ToDouble(dgv_Empleados.SelectedRows[0].Cells[9].Value.ToString().Trim());
                Obj_Empleados_DAL.iIdTipoEmpleado = Convert.ToInt32(dgv_Empleados.SelectedRows[0].Cells[10].Value.ToString().Trim());
                Obj_Empleados_DAL.iIdAerolinea = Convert.ToInt32(dgv_Empleados.SelectedRows[0].Cells[11].Value.ToString().Trim());
                Obj_Empleados_DAL.cIdEstado = Convert.ToChar(dgv_Empleados.SelectedRows[0].Cells[12].Value.ToString().Trim());

                ModificarEmpleado.Obj_Empleados_DAL = Obj_Empleados_DAL;
                ModificarEmpleado.ShowDialog();
                Hide();
                tls_txt_Filtro.Text = string.Empty;
                Cargar();

            }
            else
            {
                MessageBox.Show("No se pueden realizar la acción, debido a que no existen datos por modificar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
