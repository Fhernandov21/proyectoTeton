using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroSistema.Data
{
    class DEvento
    {

        public string Cancelar_Evento(int idEvento)
        {
            SqlConnection con = new SqlConnection();
            string rpta;

            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Cancelar_Evento";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@IdEvento", SqlDbType.Int, idEvento, 50);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk";

            }catch(Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }
        public DataTable Horas_Ocupadas (string fecha, int NoSalon)
        {
            DataTable dtItinerario = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Horas_Ocupadas";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@Fecha", SqlDbType.VarChar, fecha, 50);
                DCliente.crearParametro(cmd, "@NoSalon", SqlDbType.Int, NoSalon, 50);

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtItinerario);
            }
            catch(Exception ex)
            {
                dtItinerario = null;
            }

            return dtItinerario;
        }

        public DataTable Mostrar_EventosPendientes(string fecha)
        {
            SqlConnection con = new SqlConnection();
            DataTable dt = new DataTable();

            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Mostrar_EventosPendientes";
                cmd.CommandType = CommandType.StoredProcedure;
                DCliente.crearParametro(cmd, "@Fecha", SqlDbType.VarChar, fecha, 50);
                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dt);
                
            }
            catch(Exception ex)
            {
                dt = null;
            }
            return dt;
        }
    }
}
