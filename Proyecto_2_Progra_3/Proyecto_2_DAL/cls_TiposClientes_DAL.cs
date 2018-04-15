using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
   public class cls_TiposClientes_DAL
    {

        private char _cIdEstado,
                     _cBandAX;
        private string _sDescripcion, _sTipoCliente;

        private int _iIdTipoCliente;

        #region
        public char CIdEstado
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

        public char CBandAX
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

        public string SDescripcion
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

        public string STipoCliente
        {
            get
            {
                return _sTipoCliente;
            }

            set
            {
                _sTipoCliente = value;
            }
        }

        public int IIdTipoCliente
        {
            get
            {
                return _iIdTipoCliente;
            }

            set
            {
                _iIdTipoCliente = value;
            }
        }
        #endregion
    }
}
