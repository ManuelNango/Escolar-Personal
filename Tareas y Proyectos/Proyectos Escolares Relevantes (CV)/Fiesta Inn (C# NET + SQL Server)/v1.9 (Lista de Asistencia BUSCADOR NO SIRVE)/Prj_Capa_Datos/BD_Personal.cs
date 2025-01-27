using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using Prj_Capa_Entidad;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Prj_Capa_Datos
{
    public class BD_Personal : Cls_Conexion
    {
        public static bool saved = false;
        public static bool edited = false;

        public void BD_Registral_Personal(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Insert_Personal", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //ahora agregamos los parametros de nuestro procedimiento almacenado

                cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
                cmd.Parameters.AddWithValue("@dni", per.Dni);
                cmd.Parameters.AddWithValue("@nombreCompleto", per.Nombres); //MUCHO OJO MUCHO OJO - CLASE 5 - min-3:54
                cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
                cmd.Parameters.AddWithValue("@Domicilio", per.Direccion);
                cmd.Parameters.AddWithValue("@Correo", per.Correo);
                cmd.Parameters.AddWithValue("@Celular", per.Celular);
                cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
                cmd.Parameters.AddWithValue("@Foto", per.xImagen);
                cmd.Parameters.AddWithValue("@Id_Distrito", per.IdDistrito);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                saved = true;

            }
            catch (Exception ex)
            {
                saved = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo pasó" + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        } //FIN


        //MI VERSIÓN DE registrar personal:

        public void BD_Registral_Personal2(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Insert_Personal2", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //ahora agregamos los parametros de nuestro procedimiento almacenado

                cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
                cmd.Parameters.AddWithValue("@dni", per.Dni);
                cmd.Parameters.AddWithValue("@nombreComplto", per.Nombres); //MUCHO OJO MUCHO OJO - CLASE 5 - min-3:54
                cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
                cmd.Parameters.AddWithValue("@RFC", per.RFC);
                cmd.Parameters.AddWithValue("@Correo", per.Correo);
                cmd.Parameters.AddWithValue("@Celular", per.Celular);
                cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
                cmd.Parameters.AddWithValue("@Foto", per.xImagen);
                cmd.Parameters.AddWithValue("@Tipo", per.tipo);

                string activador = "Activo";
                cmd.Parameters.AddWithValue("@FinguerPrint",0);
                cmd.Parameters.AddWithValue("@Estado_Per", activador);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                saved = true;

            }
            catch (Exception ex)
            {
                saved = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo pasó" + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        } //FIN

        //Ahora vamos a crear un metodo para editar los datos del personal:

        public void BD_Editar_Personal(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_Update_Personal2", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //ahora agregamos los parametros de nuestro procedimiento almacenado

                cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
                cmd.Parameters.AddWithValue("@dni", per.Dni);
                cmd.Parameters.AddWithValue("@nombreCompleto", per.Nombres); //MUCHO OJO MUCHO OJO - CLASE 5 - min-3:54
                cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
                cmd.Parameters.AddWithValue("@RFC", per.RFC);
                cmd.Parameters.AddWithValue("@Correo", per.Correo);
                cmd.Parameters.AddWithValue("@Celular", per.Celular);
                cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
                cmd.Parameters.AddWithValue("@Foto", per.xImagen);
                cmd.Parameters.AddWithValue("@Tipo", per.tipo);

                /*string activador = "Activo";
                cmd.Parameters.AddWithValue("@FinguerPrint", 0);
                cmd.Parameters.AddWithValue("@Estado_Per", activador);*/

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                edited = true;

            }
            catch (Exception ex)
            {
                edited = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo pasó otra vez " + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        } //FIN

        /*public void BD_Editar_Personal(EN_Persona per)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("Sp_UPDATE_PERSONAL", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;
                //ahora agregamos los parametros de nuestro procedimiento almacenado

                cmd.Parameters.AddWithValue("@Id_Person", per.Idpersonal);
                cmd.Parameters.AddWithValue("@dni", per.Dni);
                cmd.Parameters.AddWithValue("@nombreCompleto", per.Nombres); //MUCHO OJO MUCHO OJO - CLASE 5 - min-3:54
                cmd.Parameters.AddWithValue("@FechaNacmnto", per.anoNacimiento);
                cmd.Parameters.AddWithValue("@Sexo", per.Sexo);
                cmd.Parameters.AddWithValue("@Domicilio", per.Direccion);
                cmd.Parameters.AddWithValue("@Correo", per.Correo);
                cmd.Parameters.AddWithValue("@Celular", per.Celular);
                cmd.Parameters.AddWithValue("@Id_rol", per.IdRol);
                cmd.Parameters.AddWithValue("@Foto", per.xImagen);
                cmd.Parameters.AddWithValue("@Id_Distrito", per.IdDistrito);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                edited = true;

            }
            catch (Exception ex)
            {
                edited = false;
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Algo malo pasó" + ex.Message, "Advertencia de seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        } //FIN*/

        public static bool huella = false;

        //Ahora vamos a crear un metodo para registrar la HUELLA DACTILAR del personal:
        public void BD_Registrar_Huella_Personal(string idper, object finguer)
        {
            SqlConnection cn = new SqlConnection(Conectar());
            SqlCommand cmd = new SqlCommand("SP_Actualizar_FinguerPrint", cn);

            try
            {
                cmd.CommandTimeout = 20;
                cmd.CommandType = CommandType.StoredProcedure;

                //Agregar los Parametros
                cmd.Parameters.AddWithValue("@IdPersona", idper);
                cmd.Parameters.AddWithValue("@fingerPrint", finguer);

                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();

                huella = true;
            }
            catch (Exception ex)
            {
                huella = false;
                if(cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Ejecutar el SP: " +ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //ahora vamos a crear un metodo para leer todo el personal registrado

        public DataTable BD_Leer_todoPersona()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_Listar_Personal", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Ejecutar el SP: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        public DataTable BD_Leer_todoPersona2()
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_Listar_Personal2", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Ejecutar el SP: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }

        //Ahora vamos a buscar un personal por su nombre o ID
        /*public DataTable BD_Buscar_Personal_xValor (string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_Cargar_PersonalxDni2", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Id_Pernl", valor);
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Ejecutar el SP: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }*/

        public DataTable BD_Buscar_Personal_xValor(string valor)
        {
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Cargar_PersonalxDni2", cn);  // Cambiado el nombre del procedimiento almacenado
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@Dni", valor);  // Cambiado el nombre del parámetro a @Dni
                DataTable dato = new DataTable();

                da.Fill(dato);
                da = null;
                return dato;
            }
            catch (Exception ex)
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                MessageBox.Show("Error al Ejecutar el SP: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return null;
        }





        public bool BD_Verificar_DniPersonal(string dni)
        {
            bool functionReturnValue = false;
            Int32 xfil = 0; //para saber si devulve 0 o 1

            //crear copia de la clase sql conection/comand para
            SqlConnection Cn = new SqlConnection();
            SqlCommand Cmd = new SqlCommand();
            Cn.ConnectionString = Conectar();

            var _with1 = Cmd;

            _with1.CommandText = "Sp_Validar_Dni2";    //nombre del proceso almacenado
            _with1.Connection = Cn;     //abrir conección para acceder
            _with1.CommandTimeout = 20;     //tiempo de conección 20 seg.
            _with1.CommandType = CommandType.StoredProcedure;       //decirle que trabajamos con procedi. Almac.(StoredProcedure)

            //Parametros
            _with1.Parameters.AddWithValue("@Id", dni);

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


    }
}
