using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
    public class cls_T_Usuarios_DAL
    {
        private string _sUsername, _sPassword, _sIdEmpleado;
        private char _cIdEstado, _cBandAX;
        private char _cBandLogin;

        public string sUsername
        {
            get
            {
                return _sUsername;
            }

            set
            {
                _sUsername = value;
            }
        }

        public string sPassword
        {
            get
            {
                return _sPassword;
            }

            set
            {
                _sPassword = value;
            }
        }

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

        public char cBandLogin
        {
            get
            {
                return _cBandLogin;
            }

            set
            {
                _cBandLogin = value;
            }
        }
    }
}
