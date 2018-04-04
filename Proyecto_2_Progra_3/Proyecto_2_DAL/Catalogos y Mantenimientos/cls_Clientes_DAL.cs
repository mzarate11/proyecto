using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_Clientes_DAL
    {
        private string _sIdCliente, _sCedula, _sNombre, _sApellido, _sTelefono;

        private char _cBandAxn, _cIdEstado;


        public string sIdCliente
        {
            get
            {
                return _sIdCliente;
            }

            set
            {
                _sIdCliente = value;
            }
        }

        public string sCedula
        {
            get
            {
                return _sCedula;
            }

            set
            {
                _sCedula = value;
            }
        }

        public string sNombre
        {
            get
            {
                return _sNombre;
            }

            set
            {
                _sNombre = value;
            }
        }

        public string sApellido
        {
            get
            {
                return _sApellido;
            }

            set
            {
                _sApellido = value;
            }
        }

        public string sTelefono
        {
            get
            {
                return _sTelefono;
            }

            set
            {
                _sTelefono = value;
            }
        }

        public char cBandAxn
        {
            get
            {
                return _cBandAxn;
            }

            set
            {
                _cBandAxn = value;
            }
        }

        public char cIdEstado
        {
            get
            {
                return cIdEstado;
            }

            set
            {
                cIdEstado = value;
            }
        }
    }
}
