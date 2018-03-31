using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_Vuelos_DAL
    {
        string _sIdVuelo, _sIdDestino, _sIdAvion;
        char _cIdEstado, _cbanderaAccion;
        DateTime _DtFechaHoraSalida, _DtFechaHoraLLegada;
        int _iIdAerolinea;
        char[] _cEstados;
        string[] _asIdAviones, _asIdDestinos, _asIdAerolineas;
        public string sIdVuelo
        {
            get
            {
                return _sIdVuelo;
            }

            set
            {
                _sIdVuelo = value;
            }
        }

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

        public DateTime dtFechaHoraSalida
        {
            get
            {
                return _DtFechaHoraSalida;
            }

            set
            {
                _DtFechaHoraSalida = value;
            }
        }

        public DateTime dtFechaHoraLLegada
        {
            get
            {
                return _DtFechaHoraLLegada;
            }

            set
            {
                _DtFechaHoraLLegada = value;
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

        public string[] asIdAviones
        {
            get
            {
                return _asIdAviones;
            }

            set
            {
                _asIdAviones = value;
            }
        }

        public string[] as_IdDestinos
        {
            get
            {
                return _asIdDestinos;
            }

            set
            {
                _asIdDestinos = value;
            }
        }

        public string[] asIdAerolineas
        {
            get
            {
                return _asIdAerolineas;
            }

            set
            {
                _asIdAerolineas = value;
            }
        }
    }
}
