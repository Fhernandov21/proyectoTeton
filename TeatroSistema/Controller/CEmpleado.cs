using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroSistema.Data;

namespace TeatroSistema.Controller
{
    class CEmpleado
    {
        public static DataTable Mostrar_Empleados()
        {
            return new DEmpleado().Mostrar_Empleados();
        }
        
        public static string Nuevo_Empleado(int IDEmpleado, string PrimerNombre, string SegundoNombre,
            string PrimerApellido, string SegundoApellido, string Cedula, string Direccion,
            float Salario, string Codigo)
        {
            return new DEmpleado().Nuevo_Empleado(IDEmpleado, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                Cedula, Direccion, Salario, Codigo);
        }

        public static string Actualizar_Empleado(int IDEmpleado, string PrimerNombre, string SegundoNombre,
            string PrimerApellido, string SegundoApellido, string Cedula, string Direccion,
            float Salario, string Codigo)
        {
            return new DEmpleado().Actualizar_Empleado(IDEmpleado, PrimerNombre, SegundoNombre, PrimerApellido, SegundoApellido,
                Cedula, Direccion, Salario, Codigo);
        }

        public static string Cambiar_Estado_Empleado(int IdEmpleado)
        {
            return new DEmpleado().Cambiar_Estado_Empleado(IdEmpleado);
        }

        public static DataTable Mostrar_Detalle_Empleado(int IdEmpleado)
        {
            return new DEmpleado().Mostrar_Detalle_Empleado(IdEmpleado);
        }
    }
}
