using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Proyecto_2_DAL.BaseDatos_DAL;
using Proyecto_2_DAL.Catalogos_y_Mantenimientos;

namespace Proyecto_2_BLL.Catagolos_Mantinimiento_BLL
{
    public class cls_Paises_BLL
    {
        public DataTable ListarPaises(ref string sMsgError)
        {
            cls_Bases_BLL ObjBLL = new cls_Bases_BLL();
            cls_BaseDatos_DAL ObjDAL = new cls_BaseDatos_DAL();
            ObjDAL.sNombreTabla = "PAISES";
            ObjDAL.sSentencia = ConfigurationManager.AppSettings["Listar Paises"].ToString().Trim();
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

        public DataTable FiltrarPaises(ref string sMsgError, string sFiltro)
        {
            cls_Bases_BLL ObjBLL = new cls_Bases_BLL();
            cls_BaseDatos_DAL ObjDAL = new cls_BaseDatos_DAL();
            ObjBLL.TablaParametros(ref ObjDAL);
            ObjDAL.DT_Parametros.Rows.Add("@NombrePais", 3, sFiltro);
            ObjDAL.sNombreTabla = "Filtro Paises";
            ObjDAL.sSentencia = ConfigurationManager.AppSettings["Filtrar Paises"].ToString().Trim();
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

        public void Eliminar_Paises(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Id_Pais", 1, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_Paises"].ToString().Trim();
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

        public void Insertar_Paises(ref string sMsjError, ref cls_Paises_DAL ObjPaises_DAL)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();


            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@NombrePais", 3, ObjPaises_DAL.sNombrePais.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CodigoISOPais", 2, ObjPaises_DAL.sCodigoISOPais.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CodigoAreaPais", 2, ObjPaises_DAL.sCodigoAreaPais.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 2, ObjPaises_DAL.cIdEstado.ToString().Trim());

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Insertar Paises"].ToString().Trim();
            Obj_BLL.Ejec_Scalar(ref Obj_DAL);

            if (Obj_DAL.sMsgError == string.Empty)
            {
                sMsjError = string.Empty;
                ObjPaises_DAL.iIdPais = Obj_DAL.iValorScalar;
                ObjPaises_DAL.cBandera = 'I';
            }
            else
            {
                sMsjError = Obj_DAL.sMsgError;
                ObjPaises_DAL.cBandera = 'U';
                ObjPaises_DAL.iIdPais = -1;
            }
        }

        public void Modificar_Paises(ref string sMsjError,ref cls_Paises_DAL ObjPaises_DAL)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();


            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@IdPais", 1, ObjPaises_DAL.iIdPais.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@NombrePais", 3, ObjPaises_DAL.sNombrePais.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CodigoISOPais", 2, ObjPaises_DAL.sCodigoISOPais.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@CodigoAreaPais", 2, ObjPaises_DAL.sCodigoAreaPais.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 2, ObjPaises_DAL.cIdEstado.ToString().Trim());

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Modificar Paises"].ToString().Trim();
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
