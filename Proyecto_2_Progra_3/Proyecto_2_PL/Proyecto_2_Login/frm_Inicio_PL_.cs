using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2_PL.Proyecto_2_Login
{
    public partial class frm_Inicio_PL : Form
    {
        public frm_Inicio_PL()
        {
            InitializeComponent();
        }

        private void frm_Inicio_PL_Load(object sender, EventArgs e)
        {
            tmr_Control.Start();
        }

        private void tmr_Control_Tick(object sender, EventArgs e)
        {
            if(pgb_BarraEstado.Value < 100)
            {
                pgb_BarraEstado.Value += 1;
                var contador = pgb_BarraEstado.Value;

                switch (contador)
                {
                    case 20:
                        lbl_InicioSistema.Text = "Cargando bibliotecas ...";
                        break;

                    case 30:
                        lbl_Titulo.Text = "Proyecto ...";
                        break;

                    case 60:
                        lbl_InicioSistema.Text = "Aplicando configuración ...";
                        break;

                    case 62:
                        lbl_Titulo.Text = " A _";
                        break;

                    case 64:
                        lbl_Titulo.Text = " Ae _";
                        break;

                    case 66:
                        lbl_Titulo.Text = " Aer _";
                        break;

                    case 68:
                        lbl_Titulo.Text = " Aero _";
                        break;

                    case 70:
                        lbl_Titulo.Text = " Aerop _";
                        break;
                    case 72:
                        lbl_Titulo.Text = " Aeropu _";
                        break;
                    case 74:
                        lbl_Titulo.Text = " Aeropue _";
                        break;

                    case 76:
                        lbl_Titulo.Text = " Aeropuer _";
                        break;

                    case 78:
                        lbl_Titulo.Text = " Aeropuert _";
                        break;

                    case 80:
                        lbl_Titulo.Text = " Aeropuerto _";
                        break;

                    case 82:
                        lbl_Titulo.Text = " Aeropuerto ";
                        break;

                    case 90:
                        lbl_InicioSistema.Text = " Iniciemos ... ";
                        break;

                    case 100:
                        lbl_InicioSistema.Text = "  ... ";
                        break;
                }
            }
            else
            {
                tmr_Control.Stop();
                frm_Login_PL Pantalla = new frm_Login_PL();
                Pantalla.Show();
                Hide();
            }
        }
    }
}
