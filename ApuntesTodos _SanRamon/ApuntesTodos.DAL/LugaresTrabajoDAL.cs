using System.Data;
using System.Data.SqlClient;

namespace ApuntesTodos.DAL
{
    public class LugaresTrabajoDAL
    {

        public List<string> Lugares_ObtenerTodos(out string mensaje)
        {
            List<string> lugares = new();
            mensaje = string.Empty;

            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ObtenerLugaresTrabajo", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lugares.Add(dr["NombreLugarTrabajo"].ToString()!);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Error al obtener los lugares de trabajo: " + ex.Message;
            }
            return lugares;
        }
    }
}
