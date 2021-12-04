using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroSistema.Data
{
    class DCliente
    {
        public static void crearParametro(SqlCommand cmd, string nombreParametro, SqlDbType tipoDato, object valor, int tamaño) 
        {
                        
            SqlParameter sqlpar = new SqlParameter();
            sqlpar.ParameterName = nombreParametro;
            sqlpar.SqlDbType = tipoDato;
            sqlpar.Size = tamaño;

            
            
            
            if(int.TryParse(valor.ToString(), out int valorReal))
            {
               
                sqlpar.Value = valor;
                
                                                   
            }
            else
            {
                sqlpar.Value = valor.ToString();
            }
            
            cmd.Parameters.Add(sqlpar);
        }

        public string Crear_Entidad(int IDCliente, int NoRuc, string NombreEntidad, string Direccion, string Telefono, 
            string CedulaRepresentante, string NombreRepresentante, string DireccionRep, string FechaNacimiento, string TelefonoRep)
        {
            string rpta = "a";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Crear_Entidad";
                cmd.CommandType = CommandType.StoredProcedure;

                //id
                crearParametro(cmd, "@IdCliente", SqlDbType.Int, IDCliente, 50);

                //ruc
                crearParametro(cmd, "@NoRuc", SqlDbType.VarChar, NoRuc, 50);

                //nombre
                crearParametro(cmd, "@NombreEntidad", SqlDbType.VarChar, NombreEntidad, 50);

                //direccion
                crearParametro(cmd, "@Direccion", SqlDbType.VarChar, Direccion, 100);

                //nomrep
                crearParametro(cmd, "@NombreRepresentante", SqlDbType.VarChar, NombreRepresentante, 50);

                //cedrep
                crearParametro(cmd, "@CedulaRepresentante", SqlDbType.VarChar, CedulaRepresentante, 50);

                //tel
                crearParametro(cmd, "@Telefono", SqlDbType.VarChar, Telefono, 50);
              
                //telrep
                crearParametro(cmd, "@TelefonoRepresentante", SqlDbType.VarChar, TelefonoRep, 50);

               
                //direccionrep
                crearParametro(cmd, "@DireccionRepresentante", SqlDbType.VarChar, DireccionRep, 100);

                //fechanac
                crearParametro(cmd, "@FechaNacimiento", SqlDbType.VarChar, FechaNacimiento, 50);



                rpta = cmd.ExecuteNonQuery() == 3 ? "OK" : "NotOK";


            }
            catch(Exception ex)
            {
                rpta = ex.Message;
            }

            


            return rpta;
        }

        public string Crear_Persona(int IDCliente, string PrimerNombre, string SegundoNombre, 
            string PrimerApellido, string SegundoApellido, string Direccion,
            string NoCedulaPersona, string FechaNacimeinto, string Telefono)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Crear_Persona";
                cmd.CommandType = CommandType.StoredProcedure;


                //id
                
                crearParametro(cmd, "@IDCliente", SqlDbType.Int, IDCliente, 50);

                //1nombre

                crearParametro(cmd, "@PrimerNombre", SqlDbType.VarChar, PrimerNombre, 50);

                //2nombre

                crearParametro(cmd, "@SegundoNombre", SqlDbType.VarChar, SegundoNombre, 50);

                //1apellido

                crearParametro(cmd, "@PrimerApellido", SqlDbType.VarChar, PrimerApellido, 50);

                //2apellido

                crearParametro(cmd, "@SegundoApellido", SqlDbType.VarChar, SegundoApellido, 50);

                //Direccion

                crearParametro(cmd, "@Direccion", SqlDbType.VarChar, Direccion, 50);

                //Cedula

                crearParametro(cmd, "@NoCedulaPersona", SqlDbType.VarChar, NoCedulaPersona, 50) ;

                //FechaNacimiento

                crearParametro(cmd, "@FechaNacimiento", SqlDbType.DateTime, FechaNacimeinto, 50) ;

                //Telefono

                crearParametro(cmd, "@Telefono", SqlDbType.VarChar, Telefono, 50);

                respuesta = cmd.ExecuteNonQuery() == 2 ? "OK" : "NotOK";



            }

            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;

        }
        public DataTable Mostrar_DetallesClientes(int IDCliente)
        {
            DataTable dtDetalles = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Mostrar_DetallesClientes";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter idPar = new SqlParameter();
                idPar.ParameterName = "@IDCliente";
                idPar.SqlDbType = SqlDbType.Int;
                idPar.Value = IDCliente;
                cmd.Parameters.Add(idPar);

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtDetalles);
                

            }
            catch(Exception ex)
            {
                dtDetalles = null;
            }
            return dtDetalles;
        }
        public DataTable Mostrar_Clientes()
        {
            DataTable dtClientes = new DataTable("Mostrar_Clientes");
            SqlConnection con = new SqlConnection();

            try
            {

                //cargando el servidor 
                con.ConnectionString = Conexion.Cn;
                //creando la instancia del procedimiento almacenado
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Mostrar_Clientes";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtClientes);
                
            }
            catch (Exception ex)
            {
                dtClientes = null;
            }


            return dtClientes;
        }

        public DataTable Buscar_Cliente(int id)
        {
            DataTable dtDetalles = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Buscar_Cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter idPar = new SqlParameter();
                idPar.ParameterName = "@Codigo";
                idPar.SqlDbType = SqlDbType.Int;
                idPar.Value = id;
                cmd.Parameters.Add(idPar);

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtDetalles);


            }
            catch (Exception ex)
            {
                dtDetalles = null;
            }
            return dtDetalles;
        }









    }
}
