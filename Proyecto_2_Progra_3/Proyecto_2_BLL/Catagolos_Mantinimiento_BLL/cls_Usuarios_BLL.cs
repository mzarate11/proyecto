using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using Proyecto_2_DAL.BaseDatos_DAL;

namespace Proyecto_2_BLL.Catagolos_Mantinimiento_BLL
{
    public class cls_Usuarios_BLL
    {
        public DataTable ListarUsuarios(ref string MsjError)
        {
            cls_BaseDatos_DAL objDal = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBll = new cls_Bases_BLL();

            objDal.sNombreTabla = "Usuarios";
            objDal.sSentencia = ConfigurationManager.AppSettings["Listar_Usuarios"].ToString().Trim();
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

        public DataTable FiltrarUsuarios(ref string MsjError, string sFiltroBusqueda)
        {
            cls_BaseDatos_DAL objDal = new cls_BaseDatos_DAL();
            cls_Bases_BLL objBll = new cls_Bases_BLL();

            objBll.TablaParametros(ref objDal);

            objDal.DT_Parametros.Rows.Add("@UserName", 3, sFiltroBusqueda);

            objDal.sNombreTabla = "Usuarios";
            objDal.sSentencia = ConfigurationManager.AppSettings["Filtrar_Usuarios"].ToString().Trim();
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

        public void Eliminar_Usuarios(ref string sMsjError, string sFiltro)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Username", 3, sFiltro);

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Eliminar_Usuarios"].ToString().Trim();
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


        #region  Tabla Insertar Usuarios
        public void Insertar_Usuarios(ref string sMsjError, ref Proyecto_2_DAL.Catalogos_y_Mantenimientos.cls_T_Usuarios_DAL Obj_Usuarios_DAL)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();

            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Username", 3, Obj_Usuarios_DAL.sUsername.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Password", 3, Obj_Usuarios_DAL.sPassword.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEmpleado", 3, Obj_Usuarios_DAL.sPassword.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 2, Obj_Usuarios_DAL.cIdEstado.ToString().Trim());

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Insertar_Usuarios"].ToString().Trim();
            Obj_BLL.Ejec_NonQuery(ref Obj_DAL);

            if (Obj_DAL.sMsgError == string.Empty)
            {
                sMsjError = string.Empty;
                Obj_Usuarios_DAL.cBandAX = Convert.ToChar("U");
            }
            else
            {
                sMsjError = Obj_DAL.sMsgError;
                Obj_Usuarios_DAL.cBandAX = Convert.ToChar("I");
            }
        }
        #endregion

        #region  Tabla Modificar Usuarios
        public void Modificar_Usuarios(ref string sMsjError, ref Proyecto_2_DAL.Catalogos_y_Mantenimientos.cls_T_Usuarios_DAL Obj_Usuarios_DAL)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();


            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Username", 3, Obj_Usuarios_DAL.sUsername.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Password", 3, Obj_Usuarios_DAL.sPassword.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEmpleado", 3, Obj_Usuarios_DAL.sIdEmpleado.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@IdEstado", 2, Obj_Usuarios_DAL.cIdEstado.ToString().Trim());

            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Modificar_Usuarios"].ToString().Trim();
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
        #endregion

        #region  Tabla Login Usuarios
        public void Login_Usuarios(ref string sMsjError, ref Proyecto_2_DAL.Catalogos_y_Mantenimientos.cls_T_Usuarios_DAL Obj_Usuarios_DAL)
        {
            cls_BaseDatos_DAL Obj_DAL = new cls_BaseDatos_DAL();
            cls_Bases_BLL Obj_BLL = new cls_Bases_BLL();


            Obj_BLL.TablaParametros(ref Obj_DAL);
            Obj_DAL.DT_Parametros.Rows.Add("@Username", 3, Obj_Usuarios_DAL.sUsername.ToString().Trim());
            Obj_DAL.DT_Parametros.Rows.Add("@Password", 3, Obj_Usuarios_DAL.sPassword.ToString().Trim());


            Obj_DAL.sSentencia = ConfigurationManager.AppSettings["Login_Usuarios"].ToString().Trim();
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
        #endregion

    }
}
