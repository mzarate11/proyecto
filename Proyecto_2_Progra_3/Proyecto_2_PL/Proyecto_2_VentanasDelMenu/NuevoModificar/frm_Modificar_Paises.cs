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
    public partial class frm_Modificar_Paises : Form
    {
        public frm_Modificar_Paises()
        {
            InitializeComponent();
        }

        public cls_Paises_DAL Obj_Paises_DAL;
        public void CargarDatos()
        {
            if(Obj_Paises_DAL!=null)
            {
                #region Estados
                cls_Estados_BLL ObjEstados = new cls_Estados_BLL();
                DataTable DT = new DataTable();
                string sMsjError = string.Empty;
                DT = ObjEstados.Listar_Estados(ref sMsjError);
                cmboxEstado.DataSource = DT;
                cmboxEstado.DisplayMember = DT.Columns[0].ToString();
                #endregion

                if (Obj_Paises_DAL.cBandera=='I')
                {
                    txtNombrePais.Clear();
                    txtCodigoISO.Clear();
                    txtCodigoArea.Clear();
                }
                else
                {
                    txtNombrePais.Text = Obj_Paises_DAL.sNombrePais;
                    txtCodigoISO.Text = Obj_Paises_DAL.sCodigoISOPais;
                    txtCodigoArea.Text = Obj_Paises_DAL.sCodigoAreaPais;
                    cmboxEstado.Text = Obj_Paises_DAL.cIdEstado.ToString();
                }
            }
            else
            {
                MessageBox.Show("Se presentó un error, contacte al administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void frm_Modificar_Paises_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frm_Paises Paises = new frm_Paises();
            Hide();
            Paises.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cls_Paises_BLL Obj_Paises_BLL = new cls_Paises_BLL();
            string sMsjError = string.Empty;

            Obj_Paises_DAL.sNombrePais = txtNombrePais.Text;
            Obj_Paises_DAL.sCodigoISOPais = txtCodigoISO.Text;
            Obj_Paises_DAL.sCodigoAreaPais = txtCodigoArea.Text;

            if(Obj_Paises_DAL.cBandera == 'I')
            {
                Obj_Paises_BLL.Insertar_Paises(ref sMsjError, ref Obj_Paises_DAL);
            }
            else
            {
                Obj_Paises_BLL.Modificar_Paises(ref sMsjError, ref Obj_Paises_DAL);
            }
        }
    }
}
