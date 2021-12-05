using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroSistema.Data
{
    class DRepresentante
    {
        public string CrearRepresentante (string NombreRepre , string NombreEnti , string Direccion , string Telefono , string Cedula 
            , string Fecha)
        {
            string rpta = "a"; 
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "InsertarRepresentantes";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@NombreRepre", System.Data.SqlDbType.VarChar, NombreRepre, 50);
                DCliente.crearParametro(cmd, "@NombreEnti", System.Data.SqlDbType.VarChar, NombreEnti, 50);
                DCliente.crearParametro(cmd, "@Direccion", System.Data.SqlDbType.VarChar, Direccion, 100);
                DCliente.crearParametro(cmd, "@Telefono", System.Data.SqlDbType.VarChar, Telefono, 15);
                DCliente.crearParametro(cmd, "@Cedula", System.Data.SqlDbType.NVarChar, Cedula, 15);
                DCliente.crearParametro(cmd, "@fecha", System.Data.SqlDbType.DateTime, Fecha ,50);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk"; 


            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta; 
        }

        public DataTable MostrarRepresentantes()
        {
            DataTable dtRepresen = new DataTable();
            SqlConnection con = new SqlConnection(); 
            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "MostrarRepresentantes";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtRepresen);

            }catch(Exception ex)
            {
                dtRepresen = null; 
            }
            return dtRepresen;
        }

        public string ActualizarRepre(string NombreRepre, string NombreEnti, string Direccion, string Telefono, string Cedula
            , string Fecha)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection(); 
            try
            {

                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "ActualizarRepre";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@NombreRepre", System.Data.SqlDbType.VarChar, NombreRepre, 50);
                DCliente.crearParametro(cmd, "@NombreEnti", System.Data.SqlDbType.VarChar, NombreEnti, 50);
                DCliente.crearParametro(cmd, "@Direccion", System.Data.SqlDbType.VarChar, Direccion, 100);
                DCliente.crearParametro(cmd, "@Telefono", System.Data.SqlDbType.VarChar, Telefono, 15);
                DCliente.crearParametro(cmd, "@Cedula", System.Data.SqlDbType.NVarChar, Cedula, 15);
                DCliente.crearParametro(cmd, "@fecha", System.Data.SqlDbType.DateTime, Fecha, 50);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk"; 

            }
            catch (Exception ex)
            {
                rpta = ex.Message; 
            }
            return rpta;
        }
    }
}
