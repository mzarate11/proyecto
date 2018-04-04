using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_Destinos_DAL
    {
        private string _sIdDestino, _sNomDestino;
        private char _cIdEstado,_cBandera;
        private byte _bIdAerolinea, _bPaisSalida, _bPaisLlegada;

        public string sIdDestino
        {
            get
            {
                return _sIdDestino;
            }

            set
            {
                _sIdDestino = value;
            }
        }

        public string sNomDestino
        {
            get
            {
                return _sNomDestino;
            }

            set
            {
                _sNomDestino = value;
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

        public byte bIdAerolinea
        {
            get
            {
                return _bIdAerolinea;
            }

            set
            {
                _bIdAerolinea = value;
            }
        }

        public byte bPaisSalida
        {
            get
            {
                return _bPaisSalida;
            }

            set
            {
                _bPaisSalida = value;
            }
        }

        public byte bPaisLlegada
        {
            get
            {
                return _bPaisLlegada;
            }

            set
            {
                _bPaisLlegada = value;
            }
        }

        public char cBandera
        {
            get
            {
                return _cBandera;
            }

            set
            {
                _cBandera = value;
            }
        }
    }
}
