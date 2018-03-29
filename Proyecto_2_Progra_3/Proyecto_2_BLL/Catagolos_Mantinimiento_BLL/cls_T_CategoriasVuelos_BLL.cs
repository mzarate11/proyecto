﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Proyecto_2_DAL.BaseDatos_DAL;

namespace Proyecto_2_BLL.Catagolos_Mantinimiento_BLL
{
    public class cls_T_CategoriasVuelos_BLL
    {
        #region  Tabla Listar Categorias Vuelos
        public DataTable ListarCategoriasVuelos(ref string sMsjError)
        {
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();

            Obj_DAL.sNombreTabla = "ESTADOS";
            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Listar CategoriasVuelos"].ToString().Trim();
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
        #endregion

        #region  Tabla Filtrar Categorias Vuelos


        public DataTable FiltrarCategoriasAviones(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();
            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@DescCategoria", 3, sFiltro);


            Obj_DAL.sNombreTabla = "FILTROS";
            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Filtrar CategoriasVuelos"].ToString().Trim();
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

        #endregion

        public void Eliminar_CategoriaVuelos(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Id_CategoriaVuelo", 1, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_CategoriasVuelos"].ToString().Trim();
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

    } // fin
}