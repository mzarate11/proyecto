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
            if (Obj_Paises_DAL != null)
            {
                #region Estados
                cls_Estados_BLL ObjEstados = new cls_Estados_BLL();
                DataTable DT = new DataTable();
                string sMsjError = string.Empty;
                DT = ObjEstados.Listar_Estados(ref sMsjError);
                cmboxEstado.DataSource = DT;
                DT.Rows.Add("0", "Seleccione un estado");
                cmboxEstado.DisplayMember = DT.Columns[1].ToString();
                cmboxEstado.ValueMember = DT.Columns[0].ToString();
                cmboxEstado.SelectedValue = "0";
                #endregion

                if (Obj_Paises_DAL.cBandera == 'I')
                {
                    txtNombrePais.Clear();
                    txtCodigoISO.Clear();
                    txtCodigoArea.Clear();
                }
                else
                {
                    txt_IdPais.Text = Obj_Paises_DAL.iIdPais.ToString().Trim();
                    txtNombrePais.Text = Obj_Paises_DAL.sNombrePais;
                    txtCodigoISO.Text = Obj_Paises_DAL.sCodigoISOPais;
                    txtCodigoArea.Text = Obj_Paises_DAL.sCodigoAreaPais;
                    cmboxEstado.SelectedValue = Obj_Paises_DAL.cIdEstado.ToString();
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
            if ((txtNombrePais.Text != string.Empty) || (txtCodigoArea.Text != string.Empty) || (txtCodigoISO.Text != string.Empty))
            {
                cls_Paises_BLL Obj_Paises_BLL = new cls_Paises_BLL();
                string sMsjError = string.Empty;

                Obj_Paises_DAL.iIdPais = Convert.ToInt32(txt_IdPais.Text);
                Obj_Paises_DAL.sNombrePais = txtNombrePais.Text;
                Obj_Paises_DAL.sCodigoISOPais = txtCodigoISO.Text;
                Obj_Paises_DAL.sCodigoAreaPais = txtCodigoArea.Text;
                Obj_Paises_DAL.cIdEstado = Convert.ToChar(cmboxEstado.SelectedValue);

                if (Obj_Paises_DAL.cBandera == 'I')
                {
                    Obj_Paises_BLL.Insertar_Paises(ref sMsjError, ref Obj_Paises_DAL);
                }
                else
                {
                    Obj_Paises_BLL.Modificar_Paises(ref sMsjError, ref Obj_Paises_DAL);
                }
                if(sMsjError == string.Empty)
                {
                    
                    MessageBox.Show("Se han ingresado los datos correctamente", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_IdPais.Text = Obj_Paises_DAL.iIdPais.ToString();
                    Obj_Paises_DAL.cBandera = 'U';
                }
            }
            else
            {
                MessageBox.Show("Se encuentran cajas de texto vacías, favor revisar", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNombrePais_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar)) || (e.KeyChar == Convert.ToChar(Keys.Back))||(e.KeyChar== Convert.ToChar(Keys.Space)))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCodigoISO_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCodigoArea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar == '+') && (txtCodigoArea.TextLength == 0)) ||
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
