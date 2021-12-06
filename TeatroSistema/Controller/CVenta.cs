using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroSistema.Data;

namespace TeatroSistema.Controller
{
    class CVenta
    {

        public static string Realizar_Venta(int numVenta, int idEvento, string fechaVenta, int idComprador,
            int idEmpleado, string nombre, string cedula)
        {
            return new DVenta().Realizar_Venta(numVenta, idEvento, fechaVenta, idComprador,
             idEmpleado, nombre, cedula);
        }

        public static int CargarAsientos(string salon)
        {
            return new DVenta().CargarAsientos(salon);
        }

        public static int Verificar_Asiento(int asiento, int IdEvento)
        {
            return new DVenta().Verificar_Asiento(asiento, IdEvento);
        }

        public static string Insertar_DetalleVenta(int numVenta, float costoAsiento, float porcTeatro, int asiento, string noSalon)
        {
            return new DVenta().Insertar_DetalleVenta(numVenta, costoAsiento, porcTeatro, asiento, noSalon);
        }

        public static int Cedula_Comprador_ID(string cedula)
        {
            return new DVenta().Cedula_Comprador_ID(cedula);
        }

        public static string Cedula_Comprador_NOMBRE(string cedula)
        {
            return new DVenta().Cedula_Comprador_NOMBRE(cedula);
        }

        public static int CompradorNuevo()
        {
            return new DVenta().IdCompradorNuevo();
        }



    }
}
