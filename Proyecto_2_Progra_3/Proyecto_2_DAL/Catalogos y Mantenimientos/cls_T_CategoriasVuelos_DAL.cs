using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2_DAL.Catalogos_y_Mantenimientos
{
   public class cls_T_CategoriasVuelos_DAL
    {
        private int _iIdCategoria;
        private string _sDescCategoria;
        private char _cIdEstado, _cBandAX;

        public int iIdCategoria
        {
            get
            {
                return _iIdCategoria;
            }

            set
            {
                _iIdCategoria = value;
            }
        }

        public string sDescCategoria
        {
            get
            {
                return _sDescCategoria;
            }

            set
            {
                _sDescCategoria = value;
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
    }
}
