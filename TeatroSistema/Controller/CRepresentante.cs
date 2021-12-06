using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroSistema.Data;

namespace TeatroSistema.Controller
{
    class CRepresentante
    {
        public static string CrearRepresentante(string NombreRepre,string NombreEnti ,string  Direccion, string telefono 
            , string CedulaRepresentante ,string fecha)
        {
            return new DRepresentante().CrearRepresentante(NombreRepre , NombreEnti , Direccion , telefono , CedulaRepresentante , fecha);
        }

        public static DataTable MostrarRepresentantes()
        {
            return new DRepresentante().MostrarRepresentantes(); 
        } 

        public static string ActualizarRepresentanes (string NombreRepre, string NombreEnti, string Direccion, string telefono
            , string CedulaRepresentante, string fecha)
        {
            return new DRepresentante().ActualizarRepre(NombreRepre, NombreEnti, Direccion, telefono, CedulaRepresentante, fecha); 
        }

        public static string EliminarRepresentante(string Cedula)
        {
            return new DRepresentante().EliminarRepre(Cedula);
        }
    }
}
