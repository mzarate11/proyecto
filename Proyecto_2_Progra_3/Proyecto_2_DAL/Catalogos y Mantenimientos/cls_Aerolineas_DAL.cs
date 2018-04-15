using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_Aerolineas_DAL
    {
        private int _iIdAerolinea;
        private string _sNombreAerolinea;
        private char _cIdEstado, _cBandera;

        #region Metodos get y set
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

        public string sNombreAerolinea
        {
            get
            {
                return _sNombreAerolinea;
            }

            set
            {
                _sNombreAerolinea = value;
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
        #endregion
    }
}
