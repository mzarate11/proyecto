using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_2_PL.Proyecto_2_VentanasDelMenu;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;

namespace Proyecto_2_PL.Proyecto_2_VentanaPrincipal
{
    public partial class frm_Ventana_Principal : Form
    {
        public  cls_Login_User_DAL obj_loginUser_DAL;
        string data;


        public frm_Ventana_Principal()
        {
            InitializeComponent();
        }

        private void lnklbl_Aerolineas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Aerolineas Pantalla = new frm_Aerolineas();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_Aviones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Aviones Pantalla = new frm_Aviones();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_TiposAviones_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_TiposAviones Pantalla = new frm_TiposAviones();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_Empleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Empleados Pantalla = new frm_Empleados();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_TiposClientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_TipoClientes Pantalla = new frm_TipoClientes();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_TiposEmpleados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_TipoEmpleados Pantalla = new frm_TipoEmpleados();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_CategoriaVuelos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_CategoriaVuelos Pantalla = new frm_CategoriaVuelos();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_Clientes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Clientes Pantalla = new frm_Clientes();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_Destinos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Destinos Pantalla = new frm_Destinos();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_Estados_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Estados Pantalla = new frm_Estados();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_Paises_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Paises Pantalla = new frm_Paises();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_Usuarios_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Usuarios Pantalla = new frm_Usuarios();
            Pantalla.user(lb_loginUser.Text);
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void lnklbl_Vuelos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Vuelos Pantalla = new frm_Vuelos();
            Hide();
            Pantalla.ShowDialog();
            Show();
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void frm_Ventana_Principal_Load(object sender, EventArgs e)
        {
            lb_loginUser.Text = data;
            

        }
        public void User(string sUser)
         {

            data = sUser;
        }
    }
}
