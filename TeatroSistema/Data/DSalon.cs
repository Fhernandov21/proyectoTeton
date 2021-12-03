using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeatroSistema.Data
{
    class DSalon
    {
        public string InsertarSalon(int NoSalon, string Nombre ,float Precio , int Capacidad, string Path)
        {
            string pq = "s";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "InsertarSalon";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //NoSalon 
                SqlParameter noSalon = new SqlParameter();
                noSalon.ParameterName = "@NoSalon";
                noSalon.SqlDbType = System.Data.SqlDbType.VarChar;
                noSalon.Size = 50;
                noSalon.Value = NoSalon;
                cmd.Parameters.Add(noSalon);

                //Nombre
                SqlParameter VNombre = new SqlParameter();
                VNombre.ParameterName = "@Nombre";
                VNombre.SqlDbType = System.Data.SqlDbType.VarChar;
                VNombre.Size = 50;
                VNombre.Value = Nombre;
                cmd.Parameters.Add(VNombre);

                //Path  
                SqlParameter VPrecio = new SqlParameter();
                VPrecio.ParameterName = "@Precio";
                VPrecio.SqlDbType = System.Data.SqlDbType.VarChar;
                VPrecio.Size = 50;
                VPrecio.Value = Precio;
                cmd.Parameters.Add(VPrecio);

                //Capacidad 
                SqlParameter parCapacidad = new SqlParameter();
                parCapacidad.ParameterName = "@CantidadPersonas";
                parCapacidad.SqlDbType = System.Data.SqlDbType.VarChar;
                parCapacidad.Size = 50;
                parCapacidad.Value = Capacidad;
                cmd.Parameters.Add(parCapacidad);

                //Path  
                SqlParameter VPath = new SqlParameter();
                VPath.ParameterName = "@Path";
                VPath.SqlDbType = System.Data.SqlDbType.VarChar;
                VPath.Size = 250;
                VPath.Value = Path;
                cmd.Parameters.Add(VPath);

                pq = cmd.ExecuteNonQuery() == 1 ? "OK" : "NotOK"; 
            }
            catch(Exception ex)
            {
                pq = ex.Message;
            }
            return pq;
            }

        public string ActualizarSalon(int  NoSalon , string Nombre , float Precio , int CapacidadPersonas , string path)
        {
            string pq = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "ActualizarSalon";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@NoSalon", SqlDbType.VarChar, NoSalon, 50);
                DCliente.crearParametro(cmd, "@Nombre", SqlDbType.VarChar, Nombre, 50);
                DCliente.crearParametro(cmd, "@Precio", SqlDbType.VarChar, Precio, 50);
                DCliente.crearParametro(cmd, "@Path", SqlDbType.VarChar, path, 250);
                DCliente.crearParametro(cmd, "@Capacidad", SqlDbType.VarChar, CapacidadPersonas, 50);

                pq = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOk";
            }
            catch(Exception ex)
            {
                pq = ex.Message;
            }
            return pq;
        }

        public DataTable MostrarSalones()
        {
            DataTable dtSalones = new DataTable();
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "MostrarSalones";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dat =  new SqlDataAdapter(cmd);
                dat.Fill(dtSalones); 

            }
            catch (Exception ex)
            {
                dtSalones = null; 
            }
            return dtSalones;
        }

        }     
    }

