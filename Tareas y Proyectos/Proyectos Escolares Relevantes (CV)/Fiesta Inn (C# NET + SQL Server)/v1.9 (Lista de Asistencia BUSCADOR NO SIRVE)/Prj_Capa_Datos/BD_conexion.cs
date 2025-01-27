using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Datos
{
    public class BD_conexion
    {
        //Crear metodo tipo cadena (string) y retornar la ruta donde está nuestra BD
        public string Conectar()
        {
            return @"Data Source=LAPTOP-55BL6LJM; Initial Catalog=MicroSisPlani; integrated security=true";
        }
    }
}
