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
            int idEmpleado)
        {
            return new DVenta().Realizar_Venta(numVenta, idEvento, fechaVenta, idComprador,
             idEmpleado);
        }

        public static int CargarAsientos(string salon)
        {
            return new DVenta().CargarAsientos(salon);
        }

    }
}
