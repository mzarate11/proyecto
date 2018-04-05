﻿using System;
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
    public class cls_Aerolineas_BLL
    {
        public DataTable ListarAerolineas(ref string MsjError)
        {
            cls_BaseDatos_DAL objDal = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBll = new cls_Bases_BLL();

            objDal.sNombreTabla = "Aerolineas";
            objDal.sSentencia = ConfigurationManager.AppSettings["Listar_Aerolineas"].ToString().Trim();
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

            objDal.DT_Parametros.Rows.Add("@NombreAerolinea", 3, sFiltroBusqueda);

            objDal.sNombreTabla = "Aerolineas";
            objDal.sSentencia = ConfigurationManager.AppSettings["Filtrar_Aerolineas"].ToString().Trim();
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

        public void Eliminar_Aerolineas(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdAerolinea", 1, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_Aerolineas"].ToString().Trim();
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

        public void Insertar_Aerolineas(ref string sMsjError, ref cls_Aerolineas_DAL objDAL_Aerolineas)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdAerolinea", 1, objDAL_Aerolineas.iIdAerolinea.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NombreAerolinea", 3, objDAL_Aerolineas.sNombreAerolinea.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 2, objDAL_Aerolineas.cIdEstado.ToString().Trim());

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Insertar_Aerolineas"].ToString().Trim();
            Obj_BLL.Ejec_Scalar(ref Obj_DAL);

            if(Obj_DAL.sMsgError == string.Empty)
            {
                sMsjError = string.Empty;
                objDAL_Aerolineas.iIdAerolinea = Obj_DAL.iValorScalar;
            }
            else
            {
                sMsjError = Obj_DAL.sMsgError;
                objDAL_Aerolineas.iIdAerolinea = -1;
            }

            if (Obj_DAL.sMsgError == string.Empty)
            {
                sMsjError = string.Empty;
                objDAL_Aerolineas.cBandera = 'U';
            }
            else
            {
                sMsjError = Obj_DAL.sMsgError;
                objDAL_Aerolineas.cBandera = 'I';
            }
        }

        public void Modificar_Aerolineas(ref string sMsjError, ref cls_Aerolineas_DAL objDAL_Aerolineas)
        {

        }
    }
}
