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
    public class cls_Vuelos_BLL
    {
        public DataTable ListarVuelos(ref string MsjError)
        {
            cls_BaseDatos_DAL objDal = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBll = new cls_Bases_BLL();

            objDal.sNombreTabla = "Vuelos";
            objDal.sSentencia = ConfigurationManager.AppSettings["Listar_Vuelos"].ToString().Trim();
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

        public DataTable FiltrarVuelos(ref string MsjError, string sFiltroBusqueda)
        {
            cls_BaseDatos_DAL objDal = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBll = new cls_Bases_BLL();

            objBll.TablaParametros(ref objDal);

            objDal.DT_Parametros.Rows.Add("@Idvuelo", 3, sFiltroBusqueda);

            objDal.sNombreTabla = "Vuelos";
            objDal.sSentencia = ConfigurationManager.AppSettings["Filtrar_Vuelos"].ToString().Trim();
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

        public void Eliminar_Vuelos(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdVuelo", 2, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_Vuelos"].ToString().Trim();
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

        public void ModificarVuelos(ref string sMsjError, ref cls_Vuelos_DAL Obj_Vuelos_DAL)
        {

        }

        public void AgregarVuelos(ref string sMsjError, ref cls_Vuelos_DAL Obj_Vuelos_DAL)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);

            Obj_DAL.DT_Parametros.Rows.Add("@IdVuelo", 3, Obj_Vuelos_DAL.sIdVuelo);
            Obj_DAL.DT_Parametros.Rows.Add("@IdDestino", 3, Obj_Vuelos_DAL.sIdDestino);
            Obj_DAL.DT_Parametros.Rows.Add("@IdAerolinea", 1, Obj_Vuelos_DAL.iIdAerolinea);
            Obj_DAL.DT_Parametros.Rows.Add("@IdAvion", 3, Obj_Vuelos_DAL.sIdAvion);
            Obj_DAL.DT_Parametros.Rows.Add("@FechaHoraSalida", 4, Obj_Vuelos_DAL.dtFechaHoraSalida);
            Obj_DAL.DT_Parametros.Rows.Add("@FechaHoraLlegada", 4, Obj_Vuelos_DAL.dtFechaHoraLLegada);
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 2, Obj_Vuelos_DAL.cIdEstado);


            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Insertar_Vuelos"].ToString().Trim();
            Obj_BLL.Ejec_NonQuery(ref Obj_DAL);

            if (Obj_DAL.sMsgError == string.Empty)
            {
                sMsjError = string.Empty;
                Obj_Vuelos_DAL.cbanderaAccion = 'U';
            }
            else
            {
                sMsjError = Obj_DAL.sMsgError;
                Obj_Vuelos_DAL.cbanderaAccion = 'I';
            }
        }
    }
}
