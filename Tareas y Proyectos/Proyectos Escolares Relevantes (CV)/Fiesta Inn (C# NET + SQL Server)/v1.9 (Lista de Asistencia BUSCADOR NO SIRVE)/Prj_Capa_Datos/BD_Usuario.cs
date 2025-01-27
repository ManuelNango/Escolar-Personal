using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Importar esto:
using System.Data;  //para poder usar el manejador de sql data table / data set, etc
using System.Data.SqlClient; //permite trabajar con procedimientos almacenados
using Prj_Capa_Entidad; //por si necesitamos acceder a sus propiedades get y set para registrar nuevos usuarios
using System.Windows.Forms; //para que funcione el: MessageBox.Show("Algo malo ocurrió"...

namespace Prj_Capa_Datos
{
    public class BD_Usuario : BD_conexion
    {
        
        public bool BD_Verificar_Acceso(string Usuario, string Contraseña)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0; //para saber si devulve 0 o 1

            //crear copia de la clase sql conection/comand para
            SqlConnection Cn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            Cn.ConnectionString = Conectar();

            var _with1 = Cmd;

            _with1.CommandText = "Sp_Login";    //nombre del proceso almacenado
            _with1.Connection = Cn;     //abrir conección para acceder
            _with1.CommandTimeout = 20;     //tiempo de conección 20 seg.
            _with1.CommandType = CommandType.StoredProcedure;       //decirle que trabajamos con procedi. Almac.(StoredProcedure)
            
            //Parametros
            _with1.Parameters.AddWithValue("@Usuario", Usuario);
            _with1.Parameters.AddWithValue("@Contraseña", Contraseña);

            //try para intento de conección y catch por si ocurre algún error
            try
            {
                //como el PA (Procedimiento Almacenado) devulve 1 si es verdadero y 0 si no existe
                //por eso creamos variable entera: Int32 xfil = 0;
                Cn.Open();
                xfil = (Int32)Cmd.ExecuteScalar();
                if (xfil > 0)   //si la variable es mayor que 0 entonces es 1
                {
                    functionReturnValue = true;
                }
                else //si la variable NO es mayor que 0 entonces es falso
                {
                    functionReturnValue = false;
                }

                //Cerrar todo lo utilizado para liberar recursos
                Cmd.Parameters.Clear();
                Cmd.Dispose();
                Cmd = null;
                Cn.Close();
                Cn = null;
            }
            //por si hay un error...
            catch (Exception ex)
            {
                if (Cn.State == ConnectionState.Open)   //Si el estado de conección está abierta...
                    Cn.Close(); //la cierro
                //y libero los recursos:
                Cmd.Dispose();
                Cmd = null;
                Cn.Close();
                Cn = null;

                MessageBox.Show("Algo malo ocurrió" + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw
            }
            return functionReturnValue;
        }//Fin Verificar


        public DataTable BD_Leer_Datos_Usuario(string Usuario)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Usuario_Login", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Usuario", Usuario);
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
                cn.Close();
                cn = null;
                MessageBox.Show("Algo malo pasó " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw
            }
            return null;
        }


    }
}
