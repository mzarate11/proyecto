using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Proyecto_2_DAL.BaseDatos_DAL
{
    public class cls_BaseDatos_DAL
    {
        private string _sCadena, _sMsgError, _sSentencia, _sNombreTabla;
        private SqlConnection _sql_Conexion;
        //Se utiliza para conectar a las bases de datos cuanto la conexion a la misma este abierta.
        private SqlDataAdapter _sql_DataAdapter;
        //Contenedor dinámico de datatables para insentarle tablas o contenido dinamico
        private DataSet _DataSet;
        private DataTable _DT_Parametros;
        private SqlCommand sql_CMD;

        #region Variables
        public string sCadena
        {
            get
            {
                return _sCadena;
            }

            set
            {
                _sCadena = value;
            }
        }

        public string sMsgError
        {
            get
            {
                return _sMsgError;
            }

            set
            {
                _sMsgError = value;
            }
        }

        public string sNombreTabla
        {
            get
            {
                return _sNombreTabla;
            }

            set
            {
                _sNombreTabla = value;
            }
        }


        public SqlConnection sql_Conexion
        {
            get
            {
                return _sql_Conexion;
            }

            set
            {
                _sql_Conexion = value;
            }
        }

        //Ejecuta la sentencia siempre que la conexion este activa
        public SqlDataAdapter sql_DataAdapter
        {
            get
            {
                return _sql_DataAdapter;
            }

            set
            {
                _sql_DataAdapter = value;
            }
        }

        public string sSentencia
        {
            get
            {
                return _sSentencia;
            }

            set
            {
                _sSentencia = value;
            }
        }

        public DataSet DataSet
        {
            get
            {
                return _DataSet;
            }

            set
            {
                _DataSet = value;
            }
        }

        public DataTable DT_Parametros
        {
            get
            {
                return _DT_Parametros;
            }

            set
            {
                _DT_Parametros = value;
            }
        }

        public SqlCommand Sql_CMD
        {
            get
            {
                return sql_CMD;
            }

            set
            {
                sql_CMD = value;
            }
        }

        #endregion
    }
}
