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
        int conta = 0;
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
            if (txt_Usuario.Text == "" || txt_Contraseña.Text == "")
            {
                MessageBox.Show("Alguno de los Campos esta vacido  ",
                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Focus();
            }
            else
            {
                CargarDatos();

                
            }


        }

        private void frm_Login_PL_Load(object sender, EventArgs e)
        {
            txt_Usuario.Text = "";
            txt_Usuario.Text = "";

        }

        private void CargarDatos()
        {
            cls_Usuarios_BLL obj_User_BLL = new cls_Usuarios_BLL();
            string sMsjError = string.Empty;
            DataTable DT = new DataTable();
            char cUser = 'E';
            DT = obj_User_BLL.ListarUsuarios(ref sMsjError);


            if (sMsjError == string.Empty)
            {

                int i = 0;
                foreach (DataRow row in DT.Rows)
                {
                    if (DT.Rows[i][0].ToString() == txt_Usuario.Text.ToString())
                    {
                    
                        if (DT.Rows[i][1].ToString() == txt_Contraseña.Text.ToString())
                        {
                           if (DT.Rows[i][3].ToString()=="A" || DT.Rows[i][3].ToString()=="a")
                            {

                                frm_Ventana_Principal Pantalla = new frm_Ventana_Principal();
                                Pantalla.User(txt_Usuario.Text);
                                Pantalla.Show();
                                Hide();
                                cUser = 'P';
                            }
                           else
                              {
                                  MessageBox.Show("Este usuario tine restricciones ala hora de ingresar  .\n\n Contacte al Administarador   ",
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                 cUser = 'P';
                                  txt_Contraseña.Text = "";
                                  txt_Contraseña.Focus();
                              }
                        }
                        else
                        {
                            MessageBox.Show("La contraseña que digito es incorrecta  ",
                           "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cUser = 'P';
                            txt_Contraseña.Text = "";
                            txt_Contraseña.Focus();
                        }

                    }

                    ++i;
                }



            }
            else
            {
                    MessageBox.Show("Se presento un error  favor de comunicarse con soporte   .\n\nDetalle Error : [" + sMsjError + "]",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cUser = 'P';
                    Application.Exit();
                    
            }

            if (cUser == 'E')
            {
                MessageBox.Show("El Usuario que digito es incorrecto  " + txt_Usuario.Text,
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Usuario.Text = "";
                txt_Usuario.Focus();
            }

  }

        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txt_Usuario.Text == "" || txt_Contraseña.Text == "")
                {
                    MessageBox.Show("Alguno de los Campos esta vacido  ",
                     "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_Usuario.Focus();
                }
                else
                {
                    CargarDatos();
                }

            }
        }

        private void txt_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;

            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Este campo solo admite letras ", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
