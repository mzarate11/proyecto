using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_TipoAviones_DAL
    {
        int _iCapacidadPasajeros;
        string _sNombreTipoAvion, _sDescTipoAvion, _sIdTipoAvion;
        double _dcapacidadPeso;
        char _cbanderaAccion, _cIdEstado;
        char[] _cEstados;

        public int iCapacidadPasajeros
        {
            get
            {
                return _iCapacidadPasajeros;
            }

            set
            {
                _iCapacidadPasajeros = value;
            }
        }

        public string sNombreTipoAvion
        {
            get
            {
                return _sNombreTipoAvion;
            }

            set
            {
                _sNombreTipoAvion = value;
            }
        }

        public string sDescTipoAvion
        {
            get
            {
                return _sDescTipoAvion;
            }

            set
            {
                _sDescTipoAvion = value;
            }
        }

        public char cbanderaAccion
        {
            get
            {
                return _cbanderaAccion;
            }

            set
            {
                _cbanderaAccion = value;
            }
        }

        public double dcapacidadPeso
        {
            get
            {
                return _dcapacidadPeso;
            }

            set
            {
                _dcapacidadPeso = value;
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

        public char[] cEstados
        {
            get
            {
                return _cEstados;
            }

            set
            {
                _cEstados = value;
            }
        }
    }
}
