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

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu
{
    public partial class frm_Empleados : Form
    {
        public frm_Empleados()
        {
            InitializeComponent();
        }

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
            NuevoModificar.frm_Modificar_Empleados PantEditar = new NuevoModificar.frm_Modificar_Empleados();
            PantEditar.ShowDialog();
            Show();
            this.Hide();
        }
    }
}
