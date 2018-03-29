using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_2_DAL.BaseDatos_DAL;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Proyecto_2_BLL.Catagolos_Mantinimiento_BLL
{
    public class cls_Empleados_BLL
    {
        public DataTable Filtrar_Empleados(ref string M_Error, string sFiltro)
        {
            cls_BaseDatos_DAL ObjDAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL ObjBLL = new cls_Bases_BLL();

            ObjBLL.TablaParametros(ref ObjDAL);
            ObjDAL.DT_Parametros.Rows.Add("@IdEmpleado", 3, sFiltro);
            ObjDAL.sNombreTabla = "Empleados";
            ObjDAL.sSentencia = ConfigurationManager.AppSettings["Filtrar_Empleados"].ToString().Trim();
            ObjBLL.Ejec_DataAdapter(ref ObjDAL);

            if (ObjDAL.sMsgError != string.Empty)
            {
                M_Error = ObjDAL.sMsgError;
                return null;
            }
            else
            {
                ObjDAL.sMsgError = string.Empty;
                return ObjDAL.DataSet.Tables[0];
            }
        }
        public DataTable Listar_Empleados(ref string M_Error)
        {
            cls_BaseDatos_DAL ObjDAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL ObjBLL = new cls_Bases_BLL();

            ObjDAL.sNombreTabla = "Empleados";
            ObjDAL.sSentencia = ConfigurationManager.AppSettings["Listar_Empleados"].ToString().Trim();
            ObjBLL.Ejec_DataAdapter(ref ObjDAL);
           
            if (ObjDAL.sMsgError != string.Empty)
            {
                M_Error = ObjDAL.sMsgError;
                return null;
            }
            else
            {
                ObjDAL.sMsgError = string.Empty;
                return ObjDAL.DataSet.Tables[0];
            }
        }

        public void Eliminar_Empleados(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdEmpleado", 3, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_Empleados"].ToString().Trim();
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
