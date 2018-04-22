using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_Empleados_DAL
    {
        
        private string _sNombre, _sApellidos, _sDireccion, _sIdEmpleado; 
        private int _iIdTipoEmpleado, _iIdAerolinea, _iCedula, _iTelCasa, _iTelRef, _iCelular;
        private double _dSalario;
        private ushort _uIdEmpleado;
        private byte _bEdad;
        private char _cIdEstado , _cBandera;

        #region Constructores 

        public string sIdEmpleado
        {
            get
            {
                return _sIdEmpleado;
            }

            set
            {
                _sIdEmpleado = value;
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

        public string sApellidos
        {
            get
            {
                return _sApellidos;
            }

            set
            {
                _sApellidos = value;
            }
        }

        public string sDireccion
        {
            get
            {
                return _sDireccion;
            }

            set
            {
                _sDireccion = value;
            }
        }

        public int iIdTipoEmpleado
        {
            get
            {
                return _iIdTipoEmpleado;
            }

            set
            {
                _iIdTipoEmpleado = value;
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

        public int iCedula
        {
            get
            {
                return _iCedula;
            }

            set
            {
                _iCedula = value;
            }
        }

        public int iTelCasa
        {
            get
            {
                return _iTelCasa;
            }

            set
            {
                _iTelCasa = value;
            }
        }

        public int iTelRef
        {
            get
            {
                return _iTelRef;
            }

            set
            {
                _iTelRef = value;
            }
        }

        public int iCelular
        {
            get
            {
                return _iCelular;
            }

            set
            {
                _iCelular = value;
            }
        }

        public double dSalario
        {
            get
            {
                return _dSalario;
            }

            set
            {
                _dSalario = value;
            }
        }

        public ushort uIdEmpleado
        {
            get
            {
                return _uIdEmpleado;
            }

            set
            {
                _uIdEmpleado = value;
            }
        }

        public byte bEdad
        {
            get
            {
                return _bEdad;
            }

            set
            {
                _bEdad = value;
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
        #endregion` 
    }
}
