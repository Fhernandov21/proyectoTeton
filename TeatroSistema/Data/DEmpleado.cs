using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TeatroSistema.Data
{
    class DEmpleado
    {
        public DataTable Mostrar_Empleados()
        {
            DataTable dtEmpleados = new DataTable("Mostrar_Empleados");
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Mostrar_Empleados";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtEmpleados);

            }
            catch (Exception ex)
            {
                dtEmpleados = null;
            }
            return dtEmpleados;
        }

        public string Nuevo_Empleado(int IDEmpleado, string PrimerNombre, string SegundoNombre,
            string PrimerApellido, string SegundoApellido, string Cedula, string Direccion,
            float Salario, string Codigo)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Nuevo_Empleado";
                cmd.CommandType = CommandType.StoredProcedure;

                //ID
                DCliente.crearParametro(cmd, "@IdEmpleado", SqlDbType.Int, IDEmpleado, 50);

                //primer nombre
                DCliente.crearParametro(cmd, "@PrimerNombre ", SqlDbType.VarChar, PrimerNombre, 50);

                //segundo nombre
                DCliente.crearParametro(cmd, "@SegundoNombre", SqlDbType.VarChar, SegundoNombre, 50);

                //primer apellido
                DCliente.crearParametro(cmd, "@PrimerApellido", SqlDbType.VarChar, PrimerApellido, 50);

                //segundo apellido
                DCliente.crearParametro(cmd, "@SegundoApellido", SqlDbType.VarChar, SegundoApellido, 50);

                //cedula
                DCliente.crearParametro(cmd, "@CedulaEmpleado", SqlDbType.VarChar, Cedula, 50);

                //dir
                DCliente.crearParametro(cmd, "@DireccionEmpleado", SqlDbType.VarChar, Direccion, 100);

                //Salario
                SqlParameter sqlpar = new SqlParameter();
                sqlpar.ParameterName = "@SalarioMensual";
                sqlpar.SqlDbType = SqlDbType.Float;
                sqlpar.Size = 50;
                sqlpar.Value = Salario;
                cmd.Parameters.Add(sqlpar);

                //CodEmp
                DCliente.crearParametro(cmd, "@CodigoEmpleado", SqlDbType.VarChar, Codigo, 30);

               

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOK";
            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;

        }

        public string Actualizar_Empleado(int IDEmpleado, string PrimerNombre, string SegundoNombre,
            string PrimerApellido, string SegundoApellido, string Cedula, string Direccion,
            float Salario, string Codigo)
        {
            string respuesta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Actualizar_Empleado";
                cmd.CommandType = CommandType.StoredProcedure;

                //ID
                DCliente.crearParametro(cmd, "@IdEmpleado", SqlDbType.Int, IDEmpleado, 50);

                //primer nombre
                DCliente.crearParametro(cmd, "@PrimerNombre ", SqlDbType.VarChar, PrimerNombre, 50);

                //segundo nombre
                DCliente.crearParametro(cmd, "@SegundoNombre", SqlDbType.VarChar, SegundoNombre, 50);

                //primer apellido
                DCliente.crearParametro(cmd, "@PrimerApellido", SqlDbType.VarChar, PrimerApellido, 50);

                //segundo apellido
                DCliente.crearParametro(cmd, "@SegundoApellido", SqlDbType.VarChar, SegundoApellido, 50);

                //cedula
                DCliente.crearParametro(cmd, "@CedulaEmpleado", SqlDbType.VarChar, Cedula, 50);

                //dir
                DCliente.crearParametro(cmd, "@DireccionEmpleado", SqlDbType.VarChar, Direccion, 100);

                //Salario
                SqlParameter sqlpar = new SqlParameter();
                sqlpar.ParameterName = "@SalarioMensual";
                sqlpar.SqlDbType = SqlDbType.Float;
                sqlpar.Size = 50;
                sqlpar.Value = Salario;
                cmd.Parameters.Add(sqlpar);

                //CodEmp
                DCliente.crearParametro(cmd, "@CodigoEmpleado", SqlDbType.VarChar, Codigo, 30);

                respuesta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOK";

            }
            catch (Exception ex)
            {
                respuesta = ex.Message;
            }
            return respuesta;
        }

        public string Cambiar_Estado_Empleado(int IdEmpleado)
        {
            string rpta = "";
            SqlConnection con = new SqlConnection();
            try
            {
                con.ConnectionString = Conexion.Cn;
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Cambiar_Estado_Empleado";
                cmd.CommandType = CommandType.StoredProcedure;

                DCliente.crearParametro(cmd, "@IdEmpleado", SqlDbType.Int, IdEmpleado, 50);

                rpta = cmd.ExecuteNonQuery() == 1 ? "Ok" : "NotOK";
            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;
        }

        public DataTable Mostrar_Detalle_Empleado(int IdEmpleado)
        {
            DataTable dtEmpleados = new DataTable("Mostrar_Empleados");
            SqlConnection con = new SqlConnection();

            try
            {
                con.ConnectionString = Conexion.Cn;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Mostrar_Detalle_Empleado";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter idPar = new SqlParameter();
                idPar.ParameterName = "@IDEmpleado";
                idPar.SqlDbType = SqlDbType.Int;
                idPar.Value = IdEmpleado;
                cmd.Parameters.Add(idPar);

                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtEmpleados);

            }
            catch (Exception ex)
            {
                dtEmpleados = null;
            }
            return dtEmpleados;
        }
    }
}
