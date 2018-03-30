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
    public class cls_Estados_BLL
    {

        public DataTable Listar_Estados(ref string sMsjError)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();
            Obj_DAL.sNombreTabla = "ESTADOS";
            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Listar_Estados"].ToString().Trim();
            Obj_BLL.Ejec_DataAdapter(ref Obj_DAL);

            if (Obj_DAL.sMsgError == string.Empty)
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

        public DataTable Filtrar_Estados(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Descripcion", 3, sFiltro);

            Obj_DAL.sNombreTabla = "ESTADOS";
            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Filtrar_Estados"].ToString().Trim();
            Obj_BLL.Ejec_DataAdapter(ref Obj_DAL);

            if (Obj_DAL.sMsgError == string.Empty)
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

        public void Eliminar_Estados (ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Id_Estado", 2, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_Estados"].ToString().Trim();
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

        public void Insertar_Estados(ref string sMsjError, ref cls_Estados_DAL Obj_Estados_DAL)
        {
            
        }
        public void Modificar_Estados(ref string sMsjError, ref cls_Estados_DAL Obj_Estados_DAL)
        {
            
        }
    }
}
