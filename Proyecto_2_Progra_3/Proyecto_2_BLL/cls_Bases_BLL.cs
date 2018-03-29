using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2_DAL.BaseDatos_DAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Proyecto_2_BLL
{
    public class cls_Bases_BLL
    {

        public string Encriptar(string cadena)
        {
            try
            {
                string _sResultado = string.Empty;
                byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(cadena);
                _sResultado = Convert.ToBase64String(encrypted);
                return _sResultado;
            }
            catch
            {
                return string.Empty;
            }
        }

        public string Desencriptar(string cadena)
        {
            try
            {
                string _sResultado = string.Empty;

                byte[] decrypted = Convert.FromBase64String(cadena);
                _sResultado = System.Text.Encoding.Unicode.GetString(decrypted);

                return _sResultado;
            }
            catch
            {
                return string.Empty;
            }
        }


        public void TraerConexion(ref cls_BaseDatos_DAL ObjDAL)
        {
            try
            {
                cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();
                ObjDAL.sCadena = ConfigurationManager.ConnectionStrings["CONEXION_SQL"].ToString().Trim();
                //ObjDAL.sCadena = Obj_BLL.Encriptar(ConfigurationManager.ConnectionStrings["CONEXION SQL"].ToString().Trim());
                //ObjDAL.sCadena = Obj_BLL.Desencriptar(ObjDAL.sCadena);
                ObjDAL.sql_Conexion = new SqlConnection(ObjDAL.sCadena);
                ObjDAL.sMsgError = "";
            }
            catch (Exception e)
            {
                ObjDAL.sCadena = string.Empty;
                ObjDAL.sql_Conexion = null;
                ObjDAL.sMsgError = e.Message.ToString();
            }
        }
        public void AbrirConexion(ref cls_BaseDatos_DAL ObjDAL)
        {
            try
            {
                TraerConexion(ref ObjDAL);
                if (ObjDAL.sql_Conexion != null)
                {
                    if (ObjDAL.sql_Conexion.State == ConnectionState.Closed)
                    {
                        ObjDAL.sql_Conexion.Open();
                    }
                    ObjDAL.sMsgError = "";
                }
            }
            catch (Exception e)
            {
                ObjDAL.sMsgError = e.Message.ToString();
            }
        }

        public void CerrarConexion(ref cls_BaseDatos_DAL ObjDAL)
        {
            if (ObjDAL.sql_Conexion != null)
            {
                if (ObjDAL.sql_Conexion.State == ConnectionState.Open)
                {
                    ObjDAL.sql_Conexion.Close();
                }

                ObjDAL.sql_Conexion.Dispose();
            }
        }

        public void Ejec_DataAdapter(ref cls_BaseDatos_DAL ObjDAL)
        {
            try
            {
                TraerConexion(ref ObjDAL);
                if (ObjDAL.sql_Conexion != null)
                {
                    AbrirConexion(ref ObjDAL);

                    ObjDAL.sql_DataAdapter = new SqlDataAdapter(ObjDAL.sSentencia, ObjDAL.sql_Conexion);

                    ObjDAL.sql_DataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


                    if (ObjDAL.DT_Parametros != null)
                    {
                        SqlDbType sqlDataType = SqlDbType.VarChar;
                        foreach (DataRow dr in ObjDAL.DT_Parametros.Rows)
                        {
                            switch (dr["Tipo de Dato"].ToString())
                            {
                                case "1":
                                    sqlDataType = SqlDbType.Int;
                                    break;

                                case "2":
                                    sqlDataType = SqlDbType.Char;
                                    break;

                                case "3":
                                    sqlDataType = SqlDbType.VarChar;
                                    break;

                                case "4":
                                    sqlDataType = SqlDbType.DateTime;
                                    break;

                                case "5":
                                    sqlDataType = SqlDbType.Decimal;
                                    break;
                                default:
                                    break;
                            }
                            ObjDAL.sql_DataAdapter.SelectCommand.Parameters.Add(dr["Nombre"].ToString(), sqlDataType).Value = dr["Valor"].ToString();
                        }
                    }
                    ObjDAL.DataSet = new DataSet();
                    ObjDAL.sql_DataAdapter.Fill(ObjDAL.DataSet, ObjDAL.sNombreTabla.ToString());
                   }
                
                ObjDAL.sMsgError = string.Empty;
            }
            
            catch (SqlException e)
            {
                ObjDAL.sMsgError = e.Message;
            }
           
            finally
            {
                CerrarConexion(ref ObjDAL);
            }

        }

        public void Ejec_NonQuery(ref cls_BaseDatos_DAL ObjDAL)
        {
            try
            {
                TraerConexion(ref ObjDAL);
                if (ObjDAL.sql_Conexion != null)
                {
                    AbrirConexion(ref ObjDAL);

                    ObjDAL.Sql_CMD = new SqlCommand(ObjDAL.sSentencia, ObjDAL.sql_Conexion);

                    ObjDAL.Sql_CMD.CommandType = CommandType.StoredProcedure;


                    if (ObjDAL.DT_Parametros != null)
                    {
                        SqlDbType sqlDataType = SqlDbType.VarChar;
                        foreach (DataRow dr in ObjDAL.DT_Parametros.Rows)
                        {
                            switch (dr["Tipo de Dato"].ToString())
                            {
                                case "1":
                                    sqlDataType = SqlDbType.Int;
                                    break;

                                case "2":
                                    sqlDataType = SqlDbType.Char;
                                    break;

                                case "3":
                                    sqlDataType = SqlDbType.VarChar;
                                    break;

                                case "4":
                                    sqlDataType = SqlDbType.DateTime;
                                    break;

                                case "5":
                                    sqlDataType = SqlDbType.Decimal;
                                    break;
                                default:
                                    break;
                            }
                            ObjDAL.Sql_CMD.Parameters.Add(dr["Nombre"].ToString(), sqlDataType).Value = dr["Valor"].ToString();
                        }
                    }
                    ObjDAL.Sql_CMD.ExecuteNonQuery();
                }

                ObjDAL.sMsgError = string.Empty;
            }

            catch (SqlException e)
            {
                ObjDAL.sMsgError = e.Message;
            }

            finally
            {
                CerrarConexion(ref ObjDAL);
            }

        }

        public void Ejec_Scalar(ref cls_BaseDatos_DAL ObjDAL)
        {
            try
            {
                ObjDAL.sMsgError = string.Empty;
            }
            
            catch (SqlException e)
            {
                ObjDAL.sMsgError = e.Message;
            }
            finally
            {
                if (ObjDAL.sql_Conexion != null)
                {
                    CerrarConexion(ref ObjDAL);
                }
            }

        }
        public void TablaParametros(ref cls_BaseDatos_DAL Obj_DAL)
        {
            Obj_DAL.DT_Parametros = new DataTable("Parametros");
            DataColumn dc_Nombre = new DataColumn(@"Nombre");
            DataColumn dc_TipoDato = new DataColumn(@"Tipo de Dato", typeof(byte));
            DataColumn dc_Valor = new DataColumn(@"Valor");

            Obj_DAL.DT_Parametros.Columns.Add(dc_Nombre);
            Obj_DAL.DT_Parametros.Columns.Add(dc_TipoDato);
            Obj_DAL.DT_Parametros.Columns.Add(dc_Valor);
        }
    }
}
