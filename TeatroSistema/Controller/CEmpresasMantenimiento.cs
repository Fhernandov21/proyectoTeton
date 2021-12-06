using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroSistema.Data;

namespace TeatroSistema.Controller
{
    class CEmpresasMantenimiento
    {
        public static string CrearEmpresa(int ruc ,string nombre , string direccion , string telefono )
        {
            return new DEmpresasMantenimiento().CrearEmpresa(ruc , nombre , direccion , telefono);
        }
        public static DataTable MostrarEmpresaMan()
        {
            return new DEmpresasMantenimiento().MostrarEmpresas();
        }

        public static string ActualizarEmpresaMan(int ruc , string nombre , string direccion , string telefono)
        {
            return new DEmpresasMantenimiento().ActualizarEmpresaMan(ruc , nombre , direccion , telefono);
        }

        public static string EliminarEmpresaMan (string nombre)
        {
            return new DEmpresasMantenimiento().EliminarEmpresaMan(nombre);
        }
    }
}
