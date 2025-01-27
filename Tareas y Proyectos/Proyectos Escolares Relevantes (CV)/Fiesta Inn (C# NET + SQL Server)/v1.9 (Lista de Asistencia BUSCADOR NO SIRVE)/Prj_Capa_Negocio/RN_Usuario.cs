//Importar librerias:
using Prj_Capa_Datos;
using System.Data;

namespace Prj_Capa_Negocio
{
    public class RN_Usuario
    {
        public bool RN_Verificar_Acceso(string Usuario, string Contraseña)
        {
            BD_Usuario obj = new BD_Usuario();
            return obj.BD_Verificar_Acceso(Usuario, Contraseña);

        }

        public DataTable RN_Leer_Datos_Usuario(string Usuario)
        {
            BD_Usuario obj = new BD_Usuario();
            return obj.BD_Leer_Datos_Usuario(Usuario);
        }
    }
}
