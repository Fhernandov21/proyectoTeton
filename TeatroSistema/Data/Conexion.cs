using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TeatroSistema.Data
{
    class Conexion
    {                       //ServerName + DBName + Usuario + Contraseña
        public static string Cn =
            @"Data Source=FHERNANDO; Initial Catalog=Teatro; user=adminTeatro; password=fher123";
    }
}
