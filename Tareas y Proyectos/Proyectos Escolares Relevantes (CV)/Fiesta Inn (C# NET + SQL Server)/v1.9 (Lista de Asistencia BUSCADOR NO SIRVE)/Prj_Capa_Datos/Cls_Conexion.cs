using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Datos
{
    public class Cls_Conexion
    {
        public string Conectar()
        {
            return @"Data Source=LAPTOP-55BL6LJM; Initial Catalog=MicroSisPlani; integrated security=true";
        }
    }
}
