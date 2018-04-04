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
    public class cls_TiposEmpleados_BLL
    {


        public DataTable ListarTiposEmpleados(ref string MsjError)
        {
            cls_BaseDatos_DAL objDal = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBLL = new cls_Bases_BLL();

            objDal.sNombreTabla = "Tipos Empleados";
            objDal.sSentencia = ConfigurationManager.AppSettings["Listar_TiposEmpleados"].ToString().Trim();
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

        public DataTable FiltrarTiposEmpleados(ref string MsjError, string sFiltroBusqueda)
        {
            cls_BaseDatos_DAL objDAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBLL = new cls_Bases_BLL();

            objBLL.TablaParametros(ref objDAL);

            objDAL.DT_Parametros.Rows.Add("@DescTipo", 3, sFiltroBusqueda);

            objDAL.sNombreTabla = "Tipos Empleados";
            objDAL.sSentencia = ConfigurationManager.AppSettings["Filtrar_TiposEmpleados"].ToString().Trim();
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
        public void Eliminar_TipoEmpleado(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Id_TipoEmpleado", 1, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_TiposEmpleados"].ToString().Trim();
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

        public void Insertar_TipoEmpleado(ref string sMsjError, ref cls_TipoEmpleados_DAL Obj_TiposEmpleados_DAL)
        {
            {
                cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
                cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

                Obj_BLL.TablaParametros(ref Obj_DAL);
                Obj_DAL.DT_Parametros.Rows.Add("@IdTipoEmpleado", 1, Obj_TiposEmpleados_DAL.ITipoEmpleado.ToString().Trim());
                Obj_DAL.DT_Parametros.Rows.Add("@DescTipo", 3, Obj_TiposEmpleados_DAL.SDescTipo.ToString().Trim());
                Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 2, Obj_TiposEmpleados_DAL.CIdEstado.ToString().Trim());
                


                Obj_DAL.sSentencia = ConfigurationManager.AppSettings["sp_Insertar_TiposEmpleados"].ToString().Trim();
                Obj_BLL.Ejec_NonQuery(ref Obj_DAL);

                if (Obj_DAL.sMsgError == string.Empty)
                {
                    sMsjError = string.Empty;
                   Obj_TiposEmpleados_DAL.CBandAX = 'U';
                }
                else
                {
                    sMsjError = Obj_DAL.sMsgError;
                    Obj_TiposEmpleados_DAL.CBandAX = 'I';
                }
            }
        }
        public void Modificat_TipoEmpleado(ref string sMsjError, ref cls_TipoEmpleados_DAL Obj_TiposEmpleados_DAL)
        {

        }
    }
}