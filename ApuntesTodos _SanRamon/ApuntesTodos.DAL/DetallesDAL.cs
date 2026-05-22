using ApuntesTodos.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ApuntesTodos.DAL
{
    public class DetallesDAL
    {

        public List<Detalles> Detalles_ObtenerPorEmpleado(int idEmpleado)
        {
            List<Detalles> lista = new();

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand command = new SqlCommand("SP_DetalleApuntesTodos", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@IdEmpleado", idEmpleado);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new Detalles
                            {
                                IdApunte = Convert.ToInt32(reader["IdApunte"]),
                                NombreCompleto = reader["NombreCompleto"].ToString()!,
                                LugarTrabajo = reader["LugarTrabajo"].ToString()!,
                                Origen = reader["Origen"] == DBNull.Value ? "" : reader["Origen"].ToString()!,
                                Monto = reader["Monto"] == DBNull.Value ? 0 : Convert.ToInt32(reader["Monto"]),
                                Detalle = reader["Detalle"] == DBNull.Value ? "" : reader["Detalle"].ToString()!,
                                Fecha = Convert.ToDateTime(reader["Fecha"])
                            });
                        }
                    }
                }
            }
            return lista;
        }

        public bool PagarApunte(int idApunte, string Origen, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SP_PagarApunte", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdApunte", idApunte);
                    cmd.Parameters.AddWithValue("@Origen", Origen);
                    cmd.Parameters.AddWithValue("@SePagoEn", "Salario");

                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;

                    cmd.ExecuteNonQuery();

                    resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    mensaje = cmd.Parameters["@Mensaje"].Value.ToString();

                }
            }
            return resultado;
        }
    }
}
