using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_Estados_DAL
    {
        private char _cIdEstado,
                     _cBandAX;

        private string _sDescripcion;

        public char cBandAX
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

        public char cIdEstado
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

        public string sDescripcion
        {
            get
            {
                return _sDescripcion;
            }

            set
            {
                _sDescripcion = value;
            }
        }
    }
}
