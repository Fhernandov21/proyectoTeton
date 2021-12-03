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

        public static DataTable Horas_Ocupadas(string fecha)
        {
            return new DEvento().Horas_Ocupadas(fecha);
        }

    }
}
