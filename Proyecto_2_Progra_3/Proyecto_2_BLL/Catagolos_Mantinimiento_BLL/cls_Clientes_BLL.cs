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
    public class cls_Clientes_BLL
    {
        public DataTable Listar_Clientes(ref string sMsjError)
        {
            cls_BaseDatos_DAL Obj_Clientes_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_Clientes_BLL = new cls_Bases_BLL();
            Obj_Clientes_DAL.sNombreTabla = "CLIENTES";
            Obj_Clientes_DAL.sSentencia = ConfigurationManager.AppSettings["Listar_Clientes"].ToString().Trim();
            Obj_Clientes_BLL.Ejec_DataAdapter(ref Obj_Clientes_DAL);

            if (sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                return Obj_Clientes_DAL.DataSet.Tables[0];
            }
            else
            {
                sMsjError = Obj_Clientes_DAL.sMsgError;
                return null;
            }

        }

        public DataTable Filtrar_Clientes(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();
            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Cedula", 3, sFiltro);


            Obj_DAL.sNombreTabla = "CLIENTES";
            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Filtrar_Clientes"].ToString().Trim();
            Obj_BLL.Ejec_DataAdapter(ref Obj_DAL);

            if (sMsjError == string.Empty)
            {
                sMsjError = string.Empty;
                return Obj_DAL.DataSet.Tables[0];
            }
            else
            {
                sMsjError = Obj_DAL.sMsgError;
                return null;
            }
        }

        public void Eliminar_Clientes(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdCliente", 3, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_Clientes"].ToString().Trim();
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
        public void Insertar_Clientes(ref string sMsjError, ref cls_Clientes_DAL Obj_Clientes_DAL)
        {

        }
        public void Modificar_Estados(ref string sMsjError, ref cls_Clientes_DAL Obj_Clientes_DAL)
        {

        }
    }
}
