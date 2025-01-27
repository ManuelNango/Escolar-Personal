using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Prj_Capa_Entidad;
using System.Runtime.Serialization;

namespace Prj_Capa_Datos
{
    public class BD_Rol : Cls_Conexion
    {

        public DataTable BD_Buscar_Todos_Roles()
        {
            SqlConnection xcn = new SqlConnection();
            try
            {
                xcn.ConnectionString = Conectar();
                SqlDataAdapter da = new SqlDataAdapter("Sp_Load_All_rol", xcn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable Dato = new DataTable();
                da.Fill(Dato);
                da = null;
                return Dato;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Algo malo pasó: " + ex.Message, "Advertencia de Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw
                if (xcn.State == ConnectionState.Open)
                {
                    xcn.Close();
                }

            }
            return null;
        }

    }
}