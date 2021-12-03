using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroSistema.Data;

namespace TeatroSistema.Controller
{
    class CSalon
    {
        public static DataTable MostrarSalones()
        {
            return new DSalon().MostrarSalones(); 
        }

        public static string InsertarSalon(int NoSalon, string NombreSalon, float precio, int cantidad, string path)
        {
            return new DSalon().InsertarSalon(NoSalon, NombreSalon, precio, cantidad, path);
        }
        public static string ActualizarSalon( int NoSalon , string NombreSalon , float Precio , int CantidadPersonas,
            string Path)
        {
            return new DSalon().ActualizarSalon(NoSalon , NombreSalon , Precio, CantidadPersonas , Path); 
        }
    }
}
