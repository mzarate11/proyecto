using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_TipoEmpleados_DAL
    {
        private char _cIdEstado,
                   _cBandAX;

        private int _iTipoEmpleado;
        private string _sDescTipo;

        public char CBandAX
        {
            get
            {
                return _cBandAX;
            }

            set
            {
                _cBandAX = value;
            }
        }

        public char CIdEstado
        {
            get
            {
                return _cIdEstado;
            }

            set
            {
                _cIdEstado = value;
            }
        }

        public int ITipoEmpleado
        {
            get
            {
                return _iTipoEmpleado;
            }

            set
            {
                _iTipoEmpleado = value;
            }
        }

        public string SDescTipo
        {
            get
            {
                return _sDescTipo;
            }

            set
            {
                _sDescTipo = value;
            }
        }
    }
}
