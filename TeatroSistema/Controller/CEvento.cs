using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroSistema.Data;

namespace TeatroSistema.Controller
{
    class CEvento
    {

        public static DataTable Horas_Ocupadas(string fecha, int NoSalon)
        {
            return new DEvento().Horas_Ocupadas(fecha, NoSalon);
        }
        public static DataTable Mostrar_EventosPendientes(string fecha)
        {
            return new DEvento().Mostrar_EventosPendientes(fecha);
        }
    }
}
