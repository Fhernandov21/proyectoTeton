using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using TeatroSistema.Data;

namespace TeatroSistema.Controller
{
    class CUsuario
    {
        //solo llamo a los métodos del data
        public static DataTable Validar_Acceso(string usuario, string contraseña)
        {
            return new DUsuario().Validar_Acceso(usuario, contraseña);
        }
        public static DataTable Mostrar_Usuario()
        {
            return new DUsuario().Mostrar_Usuario();
        }

        public static string Insertar_Usuario(string usuario, string contraseña, string rol)
        {
            return new DUsuario().Insertar_Usuario(usuario, contraseña, rol);
        }

        public static DataTable ObtenerRol(string usuario, string contra)
        {
            return new DUsuario().ObtenerRol(usuario, contra);
        }

        public static string Update_Usuario(int id, string usuario, string contraseña, string rol, string estado)
        {
            return new DUsuario().Update_Usuario(id, usuario, contraseña, rol, estado);
        }

        public static string Cambiar_EstadoUsuario(int IdUsuario)
        {
            return new DUsuario().Cambiar_EstadoUsuario(IdUsuario);
        }


        public static DataTable EmpleadoLoggeado(string user, string pass)
        {
            return new DUsuario().EmpleadoLoggeado(user, pass);
        }
        
    }
}
