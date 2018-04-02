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
    public partial class frm_Modificar_Destinos : Form
    {
        public frm_Modificar_Destinos()
        {
            InitializeComponent();
        }
        public cls_Destinos_DAL Obj_Destinos_DAL;

        public void CargarDatos()
        {
            if (Obj_Destinos_DAL != null)
            {
                string sMsjError = string.Empty;
                #region Aerolineas
                cls_Aerolineas_BLL ObjAerolinea = new cls_Aerolineas_BLL();
                DataTable DTA = new DataTable();
                DTA = ObjAerolinea.ListarAerolineas(ref sMsjError);
                cmboxAerolinea.DataSource = DTA;
                cmboxAerolinea.DisplayMember = DTA.Columns[0].ToString();
                #endregion

                #region Paises
                cls_Paises_BLL ObjPaises = new cls_Paises_BLL();
                DataTable DTP = new DataTable();
                DataTable DTP1 = new DataTable();
                DTP = ObjPaises.ListarPaises(ref sMsjError);
                DTP1 = ObjPaises.ListarPaises(ref sMsjError);
                cmboxPaisLlegada.DataSource = DTP;
                cmboxPaisSalida.DataSource = DTP1;
                cmboxPaisSalida.DisplayMember = DTP1.Columns[0].ToString();
                cmboxPaisLlegada.DisplayMember = DTP.Columns[0].ToString();
                #endregion

                #region Estados
                cls_Estados_BLL ObjEstados = new cls_Estados_BLL();
                DataTable DT = new DataTable();
                DT = ObjEstados.Listar_Estados(ref sMsjError);
                cmboxEstado.DataSource = DT;
                cmboxEstado.DisplayMember = DT.Columns[0].ToString();
                #endregion

                if (Obj_Destinos_DAL.cBandera == 'I')
                {
                    txt_IdDestino.Clear();
                    txt_NombreDestino.Clear();
                }
                else
                {
                    txt_IdDestino.Text = Obj_Destinos_DAL.sIdDestino;
                    cmboxAerolinea.Text = Obj_Destinos_DAL.bIdAerolinea.ToString();
                    txt_NombreDestino.Text = Obj_Destinos_DAL.sNomDestino;
                    cmboxPaisSalida.Text = Obj_Destinos_DAL.bPaisSalida.ToString();
                    cmboxPaisLlegada.Text = Obj_Destinos_DAL.bPaisLlegada.ToString();
                    cmboxEstado.Text = Obj_Destinos_DAL.cIdEstado.ToString();
                }

            }
            else
            {
                MessageBox.Show("Se presentó un error, contacte al administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        private void frm_Modificar_Destinos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frm_Destinos Destinos = new frm_Destinos();
            Hide();
            Destinos.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txt_IdDestino.Text != string.Empty) || (txt_NombreDestino.Text != string.Empty))
            {
                cls_Destinos_BLL ObjDestinos_BLL = new cls_Destinos_BLL();
                string sMsjError = string.Empty;

                Obj_Destinos_DAL.sIdDestino = txt_IdDestino.Text;
                Obj_Destinos_DAL.sNomDestino = txt_NombreDestino.Text;

                if (Obj_Destinos_DAL.cBandera == 'I')
                {
                    ObjDestinos_BLL.Insertar_Destinos(ref sMsjError, ref Obj_Destinos_DAL);
                }
                else
                {
                    ObjDestinos_BLL.Modificar_Destinos(ref sMsjError, ref Obj_Destinos_DAL);
                }
            }
            else
            {
                MessageBox.Show("Se ecnuentran cajas de texto vacías, favor revisar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_NombreDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_IdDestino_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '-' && !txt_IdDestino.Text.Contains("-")) ||
                (char.IsLetter(e.KeyChar)) ||
                (char.IsNumber(e.KeyChar)) ||
               (e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
