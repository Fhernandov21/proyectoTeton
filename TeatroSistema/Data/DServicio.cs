using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeatroSistema.Data;
namespace TeatroSistema.Data
{
    class DServicio
    {

        public string Crear_Servicio(string descripcion, float precio, int cantidadStock, 
            string estado)
        {
            string respuesta="a";
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Crear_Servicio";
                cmd.CommandType = CommandType.StoredProcedure;

                //@Descripcion varchar(100), @Precio float, @CantidadEnStock int,
                //@Estado varchar(30)

                

                DCliente.crearParametro(cmd, "@Descripcion", SqlDbType.VarChar, descripcion, 100);

                SqlParameter sqlpar = new SqlParameter();
                sqlpar.ParameterName = "@Precio";
                sqlpar.SqlDbType = SqlDbType.Decimal;
                sqlpar.Size = 50;
                sqlpar.Value = precio;
                cmd.Parameters.Add(sqlpar);

                DCliente.crearParametro(cmd, "@CantidadEnStock", SqlDbType.Int, cantidadStock, 50);

                DCliente.crearParametro(cmd, "@Estado", SqlDbType.VarChar, estado, 30);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }

            return respuesta;

        }

        public DataTable Mostrar_Servicios()
        {
            DataTable dtServicios = new DataTable();
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Mostrar_Servicios";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtServicios);
            }
            catch(Exception ex)
            {
                dtServicios = null;
            }

            return dtServicios;
        }

        public string Update_Servicio(int codigo, string descripcion, float precio, int cantidadStock)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update_Servicio";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@Codigo", SqlDbType.Int, codigo, 50);
                DCliente.crearParametro(cmd, "@Descripcion", SqlDbType.VarChar, descripcion, 50);
                DCliente.crearParametro(cmd, "@Precio", SqlDbType.Float, precio, 50);
                DCliente.crearParametro(cmd, "@Stock", SqlDbType.Int, cantidadStock, 50);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk";
                
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }

        public string Cambiar_Estado(int codigo)
        {
            string rpta = "";

            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Cambiar_Estado";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@Codigo", SqlDbType.VarChar, codigo, 50);

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
