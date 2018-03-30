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
    public class cls_TiposA_BLL
    {
        public DataTable ListarTiposA(ref string sMsjError)
        {
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();

            Obj_DAL.sNombreTabla = "LISTAR";
            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["listar_tipos_aviones"].ToString().Trim();
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

        public DataTable FiltrarTiposA(ref string sMsjError, string sFiltro)
        {

            cls_Bases_BLL Obj_BaseBLL = new cls_Bases_BLL();
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();

            Obj_BaseBLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoAvion", 3, sFiltro);

            Obj_DAL.sNombreTabla = "TIPOS_AVIONES";
            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["filtar_tipos_aviones"].ToString().Trim();
            Obj_BaseBLL.Ejec_DataAdapter(ref Obj_DAL);

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

        public void Eliminar_TiposAviones(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdTipoAvion", 3, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_tipos_aviones"].ToString().Trim();
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


        public void ModificarTipoAviones(ref string sMsjError, ref cls_TipoAviones_DAL Obj_TipoAviones_DAL)
        {

        }

        public void AgregarTipoAviones(ref string sMsjError, ref cls_TipoAviones_DAL Obj_TipoAviones_DAL)
        {

        }

    }
}
