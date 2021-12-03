using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroSistema.Data;

namespace TeatroSistema.Controller
{
    class CServicio
    {

        public static string Crear_Servicio(string descripcion, float precio, int cantidadStock,
            string estado) 
        {
            return new DServicio().Crear_Servicio(descripcion, precio, cantidadStock, estado);
            
        }

        public static DataTable Mostrar_Servicios()
        {
            return new DServicio().Mostrar_Servicios();
        }

        public static string Update_Servicio(int codigo, string descripcion, float precio, int cantidadStock)
        {
            return new DServicio().Update_Servicio(codigo, descripcion, precio, cantidadStock);
        }


        public static string Cambiar_Estado(int codigo)
        {
            return new DServicio().Cambiar_Estado(codigo);
        }

    }
}
