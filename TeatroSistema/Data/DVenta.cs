using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroSistema.Data
{
    class DVenta
    {

        public string Realizar_Venta(int numVenta, int idEvento, string fechaVenta, int idComprador,
            int idEmpleado)
        {
            string r = "";

            SqlConnection con = new SqlConnection();

            try
            {
                
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = con;
                cmd.CommandText = "Realizar_Venta";
                cmd.CommandType = CommandType.StoredProcedure;


                DCliente.crearParametro(cmd, "@NumeroVenta", SqlDbType.Int, numVenta, 50);
                DCliente.crearParametro(cmd, "@IdEvento", SqlDbType.Int, idEvento, 50);
                DCliente.crearParametro(cmd, "@FechaVenta", SqlDbType.VarChar, fechaVenta, 50);
                DCliente.crearParametro(cmd, "@IdComprador", SqlDbType.Int, idComprador, 50);
                DCliente.crearParametro(cmd, "@IdEmpleado", SqlDbType.VarChar, idEmpleado, 50);
                

                r = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk";
            }
            catch(Exception ex)
            {
                r = ex.Message;
            }


            return r;
            
        }

        public string Insertar_DetalleVenta(int numVenta, float costoAsiento, float pt, int asiento)
        {
            string r = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insertar_DetalleVenta";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@NumeroVenta", SqlDbType.Int, numVenta, 50);
                DCliente.crearParametro(cmd, "@CostoAsiento", SqlDbType.Float, costoAsiento, 50);
                DCliente.crearParametro(cmd, "@PorcTeatro", SqlDbType.Float, pt, 50);
                DCliente.crearParametro(cmd, "@Asiento", SqlDbType.Int, asiento, 50);

                r = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk";
            }
            catch(Exception ex)
            {
                r = ex.Message;
            }

            return r;
        }


        public int CargarAsientos(string salon)
        {
            int d = 0;
            SqlConnection con = new SqlConnection(Conexion.Cn);

            try
            {                 
                
                SqlCommand cmd = new SqlCommand("SELECT dbo.CargarAsientos(@NombreSalon)", con);
                con.Open();
                DCliente.crearParametro(cmd, "@NombreSalon", SqlDbType.VarChar, salon, 50);
                d = int.Parse(cmd.ExecuteScalar().ToString());
               
            }
            catch 
            {
                
            }
            return d;

        }


        public int Verificar_Asiento(int asiento, string nombreSalon)
        {
            int v = 0;
            SqlConnection con = new SqlConnection(Conexion.Cn);

            try
            {
                SqlCommand cmd = new SqlCommand("select dbo.Verificar_Asiento(@NoAsiento, @NombreSalon)", con);
                con.Open();
                DCliente.crearParametro(cmd, "@NoAsiento", SqlDbType.Int, asiento, 50);
                DCliente.crearParametro(cmd, "@NombreSalon", SqlDbType.VarChar, nombreSalon, 50);
                v = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            {

            }
            return v;
        }


        public string Insertat_Detalle( int numVenta, float costoAsiento, float porcTeatro, int asiento)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection(Conexion.Cn);

            try
            {
                SqlCommand cmd = new SqlCommand("Insertar_DetalleVenta", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@NumeroVenta", SqlDbType.Int, numVenta, 50);
                DCliente.crearParametro(cmd, "@CostoAsiento", SqlDbType.Float, costoAsiento, 50);
                DCliente.crearParametro(cmd, "@PorcTeatro", SqlDbType.Float, porcTeatro, 50);
                DCliente.crearParametro(cmd, "@Asiento", SqlDbType.Int, asiento, 50);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk"; 
                
            }catch(Exception ex)
            {
                rpta = ex.Message;
            }


            return rpta;
        }


        public string Cedula_Comprador_NOMBRE(string cedula)
        {
            string nombre = "";
            SqlConnection con = new SqlConnection(Conexion.Cn);

            try
            {
                SqlCommand cmd = new SqlCommand("select dbo.Cedula_Comprador_NOMBRE(@CedulaComprador)", con);
                con.Open();
                DCliente.crearParametro(cmd, "@CedulaComprador", SqlDbType.VarChar, cedula, 50);

                nombre = cmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                nombre = ex.Message;
            }

            return nombre;
        }


        public int Cedula_Comprador_ID(string cedula)
        {
            int id = 0;
            SqlConnection con = new SqlConnection(Conexion.Cn);

            try
            {
                SqlCommand cmd = new SqlCommand("select dbo.Cedula_Comprador_ID(@CedulaComprador)", con);
                con.Open();
                DCliente.crearParametro(cmd, "@CedulaComprador", SqlDbType.VarChar, cedula, 50);

                id = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                
            }

            return id;
        }

    }
}
