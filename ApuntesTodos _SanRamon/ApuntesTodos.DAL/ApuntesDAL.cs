using ApuntesTodos.Entities;
using System.Data;
using System.Data.SqlClient;

namespace ApuntesTodos.DAL
{
    public class ApuntesDAL
    {

        public List<Apuntes> Apuntes_ObtenerTodos()
        {
            List<Apuntes> apuntes = new();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SP_ObtenerApuntesTodos", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Apuntes apunte = new Apuntes
                            {
                                IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                NombreCompleto = reader["NombreCompleto"].ToString(),
                                LugarTrabajo = reader["LugarTrabajo"].ToString(),
                                Zarcereño = Convert.ToInt32(reader["Zarcereño"]),
                                Souvenir = Convert.ToInt32(reader["Souvenir"]),
                                Restaurante = Convert.ToInt32(reader["Restaurante"]),
                                Total = Convert.ToInt32(reader["Total"])
                            };
                            apuntes.Add(apunte);
                        }
                    }
                }
            }
            return apuntes;
        }

        public bool PagarApuntesSalario(int IdEmpleado)
        {
            bool resultado = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_PagarTodoSalario", conn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                        cmd.Parameters.AddWithValue("@SePagoEn", "Salario");

                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;

                        resultado = cmd.ExecuteNonQuery() > 0;

                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error al pagar el apunte: {ex.Message}");
            }

            return resultado;
        }

    }
}
