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
            @"Data Source=DESKTOP-JNDQ2L1\SQLEXPRESS; Initial Catalog=Teatro; user=sa; password=1234";
    }
}
