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
        public DataTable Horas_Ocupadas (string fecha)
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


                SqlDataAdapter dat = new SqlDataAdapter(cmd);
                dat.Fill(dtItinerario);
            }
            catch(Exception ex)
            {
                dtItinerario = null;
            }

            return dtItinerario;
        }


    }
}
