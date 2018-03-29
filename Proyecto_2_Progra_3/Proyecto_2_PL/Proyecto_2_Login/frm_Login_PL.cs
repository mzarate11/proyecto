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
            frm_Ventana_Principal Pantalla = new frm_Ventana_Principal();
            Pantalla.Show();
            Hide();
        }
    }
}
