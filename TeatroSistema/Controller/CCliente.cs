using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroSistema.Data;

namespace TeatroSistema.Controller
{
    class CCliente
    {

        public static DataTable Mostrar_Clientes()
        {
            return new DCliente().Mostrar_Clientes();
        }

        public static DataTable Mostrar_DetallesClientes(int IDCliente)
        {
            return new DCliente().Mostrar_DetallesClientes(IDCliente);
        }

        
        public static string Crear_Persona(int IDCliente, string PrimerNombre, string SegundoNombre,
            string PrimerApellido, string SegundoApellido, string Direccion,
            string NoCedulaPersona, string FechaNacimeinto, string Telefono)
        {
            return new DCliente().Crear_Persona(IDCliente,  PrimerNombre,  SegundoNombre,
             PrimerApellido,  SegundoApellido,  Direccion,
             NoCedulaPersona,  FechaNacimeinto,  Telefono);
        }


        public static string Crear_Entidad(int IDCliente, int NoRuc, string NombreEntidad, string Direccion, string Telefono,
            string CedulaRepresentante, string NombreRepresentante, string DireccionRep, string FechaNacimiento, string TelefonoRep)
        {
            return new DCliente().Crear_Entidad(IDCliente, NoRuc, NombreEntidad, Direccion, Telefono,
            CedulaRepresentante, NombreRepresentante,  DireccionRep,  FechaNacimiento,  TelefonoRep);
        }

        public static DataTable Buscar_Cliente(int id)
        {
            return new DCliente().Buscar_Cliente(id);
        }
    }
}
