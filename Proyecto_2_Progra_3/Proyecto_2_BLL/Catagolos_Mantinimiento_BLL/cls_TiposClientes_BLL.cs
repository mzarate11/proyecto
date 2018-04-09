using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Proyecto_2_DAL.BaseDatos_DAL;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;


namespace Proyecto_2_BLL.Catagolos_Mantinimiento_BLL
{

    public class cls_TiposClientes_BLL
    {
        public DataTable ListarTiposClientes(ref string MsjError)
        {
            cls_BaseDatos_DAL objDal = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBLL = new cls_Bases_BLL();

            objDal.sNombreTabla = "Tipos Clientes";
            objDal.sSentencia = ConfigurationManager.AppSettings["Listar_TiposClientes"].ToString().Trim();
            objBLL.Ejec_DataAdapter(ref objDal);

            if (objDal.sMsgError == string.Empty)
            {
                objDal.sMsgError = string.Empty;
                return objDal.DataSet.Tables[0];
            }
            else
            {
                MsjError = objDal.sMsgError;
                return null;
            }
        }

        public DataTable FiltrarTiposClientes(ref string MsjError, string sFiltroBusqueda)
        {
            cls_BaseDatos_DAL objDAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBLL = new cls_Bases_BLL();

            objBLL.TablaParametros(ref objDAL);

            objDAL.DT_Parametros.Rows.Add("@Descripcion", 3, sFiltroBusqueda);

            objDAL.sNombreTabla = "Tipos Clientes";
            objDAL.sSentencia = ConfigurationManager.AppSettings["Filtrar_TiposClientes"].ToString().Trim();
            objBLL.Ejec_DataAdapter(ref objDAL);

            if (objDAL.sMsgError == string.Empty)
            {
                objDAL.sMsgError = string.Empty;
                return objDAL.DataSet.Tables[0];
            }
            else
            {
                objDAL.sMsgError = string.Empty;
                return null;
            }
        }

        public void Eliminar_TipoCliente(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Id_TipoCliente", 1, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_TiposClientes"].ToString().Trim();
            Obj_BLL.Ejec_NonQuery(ref Obj_DAL);

            if (Obj_DAL.sMsgError == string.Empty)
            {
                sMsjError = string.Empty;
            }
            else
            {
                sMsjError = Obj_DAL.sMsgError;
            }
        }

        public void Insertar_TipoCliente(ref string sMsjError, ref cls_TiposClientes_DAL Obj_TiposClientes_DAL )
        {
            {
                cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
                cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

                Obj_BLL.TablaParametros(ref Obj_DAL);
                Obj_DAL.DT_Parametros.Rows.Add("@TipoCliente", 3, Obj_TiposClientes_DAL.STipoCliente.ToString().Trim());
                Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_TiposClientes_DAL.SDescripcion.ToString().Trim());
                Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 2, Obj_TiposClientes_DAL.CIdEstado.ToString().Trim());
                

                Obj_DAL.sSentencia = ConfigurationManager.AppSettings["sp_Insertar_TiposClientes"].ToString().Trim();
                Obj_BLL.Ejec_Scalar(ref Obj_DAL);

                if (Obj_DAL.sMsgError == string.Empty)
                {
                    sMsjError = string.Empty;
                    Obj_TiposClientes_DAL.IIdTipoCliente = Obj_DAL.iValorScalar;
                    Obj_TiposClientes_DAL.CBandAX = 'I';
                }
                else
                {
                    sMsjError = Obj_DAL.sMsgError;
                    Obj_TiposClientes_DAL.IIdTipoCliente = -1;
                    Obj_TiposClientes_DAL.CBandAX = 'U';
                }
            }
        }
        public void Modificar_TipoCliente(ref string sMsjError, ref cls_TiposClientes_DAL Obj_TiposClientes_DAL)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();


            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoCliente", 3, Obj_TiposClientes_DAL.STipoCliente.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@TipoCliente", 3, Obj_TiposClientes_DAL.STipoCliente.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, Obj_TiposClientes_DAL.SDescripcion.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 2, Obj_TiposClientes_DAL.CIdEstado.ToString().Trim());

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["sp_modificar_TiposClientes"].ToString().Trim();
            Obj_BLL.Ejec_NonQuery(ref Obj_DAL);

            if (Obj_DAL.sMsgError == string.Empty)
            {
                sMsjError = string.Empty;
            }
            else
            {
                sMsjError = Obj_DAL.sMsgError;

            }

        }
    }
}