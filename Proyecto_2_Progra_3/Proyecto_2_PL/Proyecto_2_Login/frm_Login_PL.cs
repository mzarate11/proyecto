using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_2_PL.Proyecto_2_VentanaPrincipal;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;
using Proyecto_2_BLL.Catagolos_Mantinimiento_BLL;

namespace Proyecto_2_PL.Proyecto_2_Login
{
    public partial class frm_Login_PL : Form
    {
        public frm_Login_PL()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Ingreso_Click(object sender, EventArgs e)
        {
            cls_Usuarios_BLL Obj_Usuario_BLL = new cls_Usuarios_BLL();
            cls_T_Usuarios_DAL Obj_Usuarios_DAL = new cls_T_Usuarios_DAL();
            string sMsjError = string.Empty;

            if (txt_Usuario.Text == "" || txt_Contraseña.Text == "")
            {
                MessageBox.Show("Alguno de lo campos esta vacio favor de verificar ... ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (txt_Usuario.Text == "")
                {
                    txt_Usuario.Focus();
                }
                else
                {
                    txt_Contraseña.Focus();
                }
            }
            else
            {
                Obj_Usuarios_DAL.sUsername = txt_Usuario.Text;
                Obj_Usuarios_DAL.sPassword = txt_Contraseña.Text;
                Obj_Usuario_BLL.Login_Usuarios(ref sMsjError, ref Obj_Usuarios_DAL);

                if (Obj_Usuarios_DAL.cBandLogin == 'T')
                {
                    frm_Ventana_Principal Pantalla = new frm_Ventana_Principal();
                    Pantalla.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("El Usuario o la contraseña no son validos favor de intentar de nuevo ... ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txt_Contraseña.Text = string.Empty;
                    txt_Usuario.Text = string.Empty;

                }
            }
        }
    }
}
