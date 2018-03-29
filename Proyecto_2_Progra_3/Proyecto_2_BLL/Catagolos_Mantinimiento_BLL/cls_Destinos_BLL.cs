﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Proyecto_2_DAL.BaseDatos_DAL;

namespace Proyecto_2_BLL.Catagolos_Mantinimiento_BLL
{
    public class cls_Destinos_BLL
    {
        public DataTable ListarDestinos(ref string sMsgError)
        {
            cls_Bases_BLL ObjBLL = new cls_Bases_BLL();
            cls_BaseDatos_DAL ObjDAL = new cls_BaseDatos_DAL();
            ObjDAL.sNombreTabla = "DESTINOS";
            ObjDAL.sSentencia = ConfigurationManager.AppSettings["Listar Destinos"].ToString().Trim();
            ObjBLL.Ejec_DataAdapter(ref ObjDAL);

            if (ObjDAL.sMsgError == string.Empty)
            {
                sMsgError = string.Empty;
                return ObjDAL.DataSet.Tables[0];
            }
            else
            {
                sMsgError = ObjDAL.sMsgError;
                return null;
            }
        }

        public DataTable FiltrarDestinos(ref string sMsgError, string sFiltro)
        {
            cls_Bases_BLL ObjBLL = new cls_Bases_BLL();
            cls_BaseDatos_DAL ObjDAL = new cls_BaseDatos_DAL();
            ObjBLL.TablaParametros(ref ObjDAL);
            ObjDAL.DT_Parametros.Rows.Add("@NomDestino", 3, sFiltro);
            ObjDAL.sNombreTabla = "Filtro Destinos";
            ObjDAL.sSentencia = ConfigurationManager.AppSettings["Filtrar Destinos"].ToString().Trim();
            ObjBLL.Ejec_DataAdapter(ref ObjDAL);

            if (ObjDAL.sMsgError == string.Empty)
            {
                sMsgError = string.Empty;
                return ObjDAL.DataSet.Tables[0];
            }
            else
            {
                sMsgError = ObjDAL.sMsgError;
                return null;
            }
        }

        public void Eliminar_Destinos(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Id_Destino", 3, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_Destinos"].ToString().Trim();
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
