using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_Aviones_DAL
    {
        private string _sIdAvion;
        private string _sNomAvion;
        private string _sDescAvion;
        private Int32 _iIdAerolinea;
        private string _sIdTipoAvion;
        private char _cIdEstado, _cBandera;

        #region Metodos get y set
        public string sIdAvion
        {
            get
            {
                return _sIdAvion;
            }

            set
            {
                _sIdAvion = value;
            }
        }

        public string sNomAvion
        {
            get
            {
                return _sNomAvion;
            }

            set
            {
                _sNomAvion = value;
            }
        }

        public string sDescAvion
        {
            get
            {
                return _sDescAvion;
            }

            set
            {
                _sDescAvion = value;
            }
        }

        public string sIdTipoAvion
        {
            get
            {
                return _sIdTipoAvion;
            }

            set
            {
                _sIdTipoAvion = value;
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

        public int iIdAerolinea
        {
            get
            {
                return _iIdAerolinea;
            }

            set
            {
                _iIdAerolinea = value;
            }
        }
        #endregion
    }
}
