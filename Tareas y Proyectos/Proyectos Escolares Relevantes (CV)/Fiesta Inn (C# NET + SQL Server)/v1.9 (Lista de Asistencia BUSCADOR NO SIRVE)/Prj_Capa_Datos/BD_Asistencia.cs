using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using Prj_Capa_Entidad;

namespace Prj_Capa_Datos
{
    public class BD_Asistencia : Cls_Conexion
    {
        public DataTable BD_Ver_Todas_Asistencia() ///Todo se guardará en un DataTable
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Todas_Asistencias", xcn); //SqlDataAdapter Esto es para Consultar y para insertar o eliminar SqlCommand
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //da.SelectCommand.Parameters.AddWithValue("@fecha", xdia);
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;
            }
            catch (Exception ex)
            {
                if(xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error " + ex.Message, ex);
                }
            }
            return null;
        }

        public DataTable BD_Ver_Todas_Asistencia_Deldia(DateTime xfecha)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_deldia", xcn); 
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", xfecha);
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error " + ex.Message, ex);
                }
            }
            return null;
        }

        public DataTable BD_Ver_Todas_Asistencia_DelMes(DateTime xfecha)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_Asistencia_xfecha", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@fecha", xfecha);
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error " + ex.Message, ex);
                }
            }
            return null;
        }

        public DataTable BD_Ver_Todas_Asistencia_ParaExplorador(String xvalor)
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Buscar_Asistencia_paraExplorador", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Is_Asis", xvalor);
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;
            }
            catch (Exception ex)
            {
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                    throw new Exception("Error " + ex.Message, ex);
                }
            }
            return null;
        }

    }
}
