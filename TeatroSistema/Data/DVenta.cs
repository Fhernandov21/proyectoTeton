using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeatroSistema.Data
{
    class DVenta
    {

        public string Realizar_Venta(int numVenta, int idEvento, string fechaVenta, int idComprador,
            int idEmpleado, string nombreComprador, string cedulaComprador)
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
                DCliente.crearParametro(cmd, "@NombreComprador", SqlDbType.VarChar, nombreComprador, 50);
                DCliente.crearParametro(cmd, "@CedulaComprador", SqlDbType.VarChar, cedulaComprador, 50);


                int k = cmd.ExecuteNonQuery();
                if (k == 1 || k == 2)
                {
                    r = "Ok";

                }
                else
                {
                    r = "ejkjeje";
                }
            }
            catch (Exception ex)
            {
                r = ex.Message;
            }


            return r;

        }

        public string Insertar_DetalleVenta(int numVenta, float costoAsiento, float pt, int asiento, string noSalon)
        {
            string r = "";
            SqlConnection con = new SqlConnection(Conexion.Cn);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "GenerarDetalle_Venta";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@NumeroVenta", SqlDbType.Int, numVenta, 50);
                DCliente.crearParametro(cmd, "@CostoAsiento", SqlDbType.Float, costoAsiento, 50);
                DCliente.crearParametro(cmd, "@PorcTeato", SqlDbType.Float, pt, 50);
                DCliente.crearParametro(cmd, "@Asiento", SqlDbType.Int, asiento, 50);
                DCliente.crearParametro(cmd, "@NombreSalon", SqlDbType.VarChar, noSalon, 50);
                r = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk";
            }
            catch (Exception ex)
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


        public int Verificar_Asiento(int asiento, int IdEvento)
        {
            int v = 0;
            SqlConnection con = new SqlConnection(Conexion.Cn);

            try
            {
                SqlCommand cmd = new SqlCommand("select dbo.Verificar_Asiento(@NoAsiento, @NombreSalon)", con);
                con.Open();
                DCliente.crearParametro(cmd, "@NoAsiento", SqlDbType.Int, asiento, 50);
                DCliente.crearParametro(cmd, "@IdEvento", SqlDbType.VarChar, IdEvento, 50);
                v = int.Parse(cmd.ExecuteScalar().ToString());
            }
            catch
            {

            }
            return v;
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


        public int IdCompradorNuevo()
        {
            SqlConnection con = new SqlConnection(Conexion.Cn);
            int id = 0;

            try
            {
                SqlCommand cmd = new SqlCommand("select dbo.IdCompradorMaximo()", con);
                con.Open();
                id = int.Parse(cmd.ExecuteScalar().ToString()) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return id;
        }

    }
}
