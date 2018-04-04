using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_Paises_DAL
    {
        private string _sNombrePais, _sCodigoISOPais, _sCodigoAreaPais;
        private char _cIdEstado, _cBandera;
        private int _iIdPais;

        public string sNombrePais
        {
            get
            {
                return _sNombrePais;
            }

            set
            {
                _sNombrePais = value;
            }
        }

        public string sCodigoISOPais
        {
            get
            {
                return _sCodigoISOPais;
            }

            set
            {
                _sCodigoISOPais = value;
            }
        }

        public string sCodigoAreaPais
        {
            get
            {
                return _sCodigoAreaPais;
            }

            set
            {
                _sCodigoAreaPais = value;
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

        public int iIdPais
        {
            get
            {
                return _iIdPais;
            }

            set
            {
                _iIdPais = value;
            }
        }
    }
}
