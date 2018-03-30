using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2_PL.Proyecto_2_VentanasDelMenu.NuevoModificar
{
    public partial class fmr_ModificarNuevo_Vuelos : Form
    {
        public fmr_ModificarNuevo_Vuelos()
        {
            InitializeComponent();
        }

        private void fmr_ModificarNuevo_Vuelos_Load(object sender, EventArgs e)
        {
            time_HoraLlegada.Format = DateTimePickerFormat.Custom;
            time_HoraLlegada.CustomFormat = "hh:mm tt";

            time_HoraSalida.Format = DateTimePickerFormat.Custom;
            time_HoraSalida.CustomFormat = "hh:mm tt";
        }
    }
}
