using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Proyecto_2_BLL;
using Proyecto_2_DAL.BaseDatos_DAL;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;

namespace Proyecto_2_BLL.Catagolos_Mantinimiento_BLL
{
    public class cls_Aviones_BLL
    {
        public DataTable ListarAvion(ref string MsjError)
        {
            cls_BaseDatos_DAL objDal = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBll = new cls_Bases_BLL();

            objDal.sNombreTabla = "Aviones";
            objDal.sSentencia = ConfigurationManager.AppSettings["Listar_Aviones"].ToString().Trim();
            objBll.Ejec_DataAdapter(ref objDal);

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

        public DataTable FiltrarAerolineas(ref string MsjError, string sFiltroBusqueda)
        {
            cls_BaseDatos_DAL objDal = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBll = new cls_Bases_BLL();

            objBll.TablaParametros(ref objDal);

            objDal.DT_Parametros.Rows.Add("@IdAvion", 3, sFiltroBusqueda);

            objDal.sNombreTabla = "Aviones";
            objDal.sSentencia = ConfigurationManager.AppSettings["Filtrar_Aviones"].ToString().Trim();
            objBll.Ejec_DataAdapter(ref objDal);

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

        public void Eliminar_Aviones(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdAvion", 3, sFiltro);

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

        public void Insertar_Aviones(ref string sMsjError, ref cls_Aviones_DAL objDAL_Aviones)
        {

        }

        public void Modificar_Aviones(ref string sMsjError, ref cls_Aviones_DAL objDAL_Aviones)
        {

        }

    }
}
