using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroSistema.Data
{
    class DEmpresasMantenimiento
    {
        public string CrearEmpresa (int ruc , string nombre , string direccion ,string telefono)
        {
            string rpta = "a";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "CrearEmpresaMan";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@Ruc", System.Data.SqlDbType.Int, ruc, 50);
                DCliente.crearParametro(cmd, "@Nombre", System.Data.SqlDbType.VarChar, nombre, 50);
                DCliente.crearParametro(cmd, "@Direccion", System.Data.SqlDbType.VarChar, direccion, 100);
                DCliente.crearParametro(cmd, "@Telefono", System.Data.SqlDbType.VarChar, telefono, 15);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok " : "NotOk"; 

            }
            catch (Exception ex) {

                rpta = ex.Message; 

            }
            return rpta; 
        }
        public DataTable MostrarEmpresas()
        {
            DataTable dtMostrarEmpresas = new DataTable();
            SqlConnection con = new SqlConnection();
            try{
                con.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "MostrarEmpresasMan";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtMostrarEmpresas); 

            }catch (Exception ex)
            {
                dtMostrarEmpresas = null;
            }
            return dtMostrarEmpresas; 
        }

        public string ActualizarEmpresaMan(int ruc, string nombre, string direccion, string telefono)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {

                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "ActualizarEmpresaMan";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@Ruc", System.Data.SqlDbType.Int, ruc, 50);
                DCliente.crearParametro(cmd, "@Nombre", System.Data.SqlDbType.VarChar, nombre, 50);
                DCliente.crearParametro(cmd, "@Direccion", System.Data.SqlDbType.VarChar, direccion, 100);
                DCliente.crearParametro(cmd, "@Telefono", System.Data.SqlDbType.VarChar, telefono, 15);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            return rpta;
        }

        public string EliminarEmpresaMan (string nombre)
        {
            string rpta = "a";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "EliminarEmpresaMan";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parNombre = new SqlParameter();
                parNombre.ParameterName = "@Nombre";
                parNombre.SqlDbType = SqlDbType.VarChar;
                parNombre.Size = 50;
                parNombre.Value = nombre;
                cmd.Parameters.Add(parNombre);

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
