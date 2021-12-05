using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace TeatroSistema.Data
{
    class DUsuario
    {


        public DataTable Validar_Acceso(string usuario, string contraseña)
        {
            DataTable DtResultado = new DataTable("Inicio_Sesión");
            SqlConnection SqlCon = new SqlConnection();
            try
            {   //cargando la conexión del servidor

                SqlCon.ConnectionString = Conexion.Cn;

                //Creando un objeto sqlcommand que llamará al proceso almacenado validar acceso
                SqlCommand SqlCmd = new SqlCommand(); //creo el sqlcommand
                SqlCmd.Connection = SqlCon;             //creo la conexión
                SqlCmd.CommandText = "Validar_Acceso";  //Le digo el nombre del procedimiento
                SqlCmd.CommandType = CommandType.StoredProcedure; //Le digo que es un storedprocedure

                //Cargando los parámetros del procedimiento almacenado

                //usuario
                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 80;
                ParUsuario.Value = usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                //contraseña
                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@contraseña";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 80;
                ParContraseña.Value = contraseña;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable ObtenerRol(string usuario, string contrasenia)
        {
            DataTable DtResultado = new DataTable("Roles");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;

                //Creando el sql comand que llamara el proceso 

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "ObtenerRol";  //Le digo el nombre del procedimiento
                SqlCmd.CommandType = CommandType.StoredProcedure; //Le digo que es un storedprocedure

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParContraseña = new SqlParameter();
                ParContraseña.ParameterName = "@contraseña";
                ParContraseña.SqlDbType = SqlDbType.VarChar;
                ParContraseña.Size = 50;
                ParContraseña.Value = contrasenia;
                SqlCmd.Parameters.Add(ParContraseña);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch
            {
                Console.WriteLine("Tengo errores  , me siento malito ... ");
            }

            return DtResultado;
        }

        public DataTable Mostrar_Usuario()
        {
            DataTable DtResultado = new DataTable("MostrarUsuario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {    // Cargando el conexión al servidor
                SqlCon.ConnectionString = Conexion.Cn;
                // Creando un objeto SQLCommand que llamará al procedimiento almacenado
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "Mostrar_Usuario";
                SqlCmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);


            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public string Cambiar_EstadoUsuario(int IdUsuario)
        {
            string ans = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Cambiar_EstadoUsuario";
                cmd.CommandType = CommandType.StoredProcedure;

                //parametros: instancia - @Parname - dbtype - size - value - add al cmd 
                //id
                SqlParameter idPar = new SqlParameter();
                idPar.ParameterName = "@IdUsuario";
                idPar.SqlDbType = SqlDbType.Int;
                idPar.Size = 80;
                idPar.Value = IdUsuario;
                cmd.Parameters.Add(idPar);

                ans = cmd.ExecuteNonQuery() == 1 ? "OK" : "NotOK";
            }
            catch (Exception ex)
            {
                ans = ex.Message;
            }


            return ans;
        }
        public string Update_Usuario(int IdUsuario, string usuario, string contraseña, string rol, string estado)
        {
            string ans = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Update_Usuario";
                cmd.CommandType = CommandType.StoredProcedure;

                //parametros: instancia - @Parname - dbtype - size - value - add al cmd 
                //id
                SqlParameter idPar = new SqlParameter();
                idPar.ParameterName = "@IdUsuario";
                idPar.SqlDbType = SqlDbType.Int;
                idPar.Size = 80;
                idPar.Value = IdUsuario;
                cmd.Parameters.Add(idPar);

                //usuario
                SqlParameter parUser = new SqlParameter();
                parUser.ParameterName = "@usuario";
                parUser.SqlDbType = SqlDbType.VarChar;
                parUser.Size = 80;
                parUser.Value = usuario;
                cmd.Parameters.Add(parUser);

                //contraseña
                SqlParameter parPass = new SqlParameter();
                parPass.ParameterName = "@contraseña";
                parPass.SqlDbType = SqlDbType.VarChar;
                parPass.Size = 80;
                parPass.Value = contraseña;
                cmd.Parameters.Add(parPass);

                //rol
                SqlParameter parRol = new SqlParameter();
                parRol.ParameterName = "@rol";
                parRol.SqlDbType = SqlDbType.VarChar;
                parRol.Size = 80;
                parRol.Value = rol;
                cmd.Parameters.Add(parRol);

                //estado
                SqlParameter parEst = new SqlParameter();
                parEst.ParameterName = "@estado";
                parEst.SqlDbType = SqlDbType.VarChar;
                parEst.Size = 80;
                parEst.Value = estado;
                cmd.Parameters.Add(parEst);

                ans = cmd.ExecuteNonQuery() == 1 ? "OK" : "NotOK";
            }
            catch (Exception ex)
            {
                ans = ex.Message;
            }

            return ans;
        }
        public string Insertar_Usuario(string usuario, string contraseña, string rol)
        {
            string ans = "";
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insertar_Usuario";
                cmd.CommandType = CommandType.StoredProcedure;


                //usuario
                SqlParameter parUser = new SqlParameter();
                parUser.ParameterName = "@usuario";
                parUser.SqlDbType = SqlDbType.VarChar;
                parUser.Size = 80;
                parUser.Value = usuario;
                cmd.Parameters.Add(parUser);

                //contraseña
                SqlParameter parPass = new SqlParameter();
                parPass.ParameterName = "@contraseña";
                parPass.SqlDbType = SqlDbType.VarChar;
                parPass.Size = 80;
                parPass.Value = contraseña;
                cmd.Parameters.Add(parPass);

                //rol
                SqlParameter parRol = new SqlParameter();
                parRol.ParameterName = "@rol";
                parRol.SqlDbType = SqlDbType.VarChar;
                parRol.Size = 80;
                parRol.Value = rol;
                cmd.Parameters.Add(parRol);

                //ejecutar insertar usuario

                ans = cmd.ExecuteNonQuery() == 1 ? "OK" : "NotOK";






            }
            catch (Exception ex)
            {
                ans = ex.Message;
            }


            return ans;
        }
        


        public DataTable EmpleadoLoggeado(string user, string pass)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(Conexion.Cn);

            try
            {
                SqlCommand cmd = new SqlCommand("Empleado_Loggeado", con);
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                DCliente.crearParametro(cmd, "@Usuario", SqlDbType.VarChar, user, 50);
                DCliente.crearParametro(cmd, "@Contraseña", SqlDbType.VarChar, pass, 50);

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                
                dat.Fill(dt);


            }
            catch(Exception ex)
            {
                dt.Rows.Add(new object[] { ex.Message });
                //dt = null;
            }


            return dt;
        }


    }
}
