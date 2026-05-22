using ApunteEmpleados.Entities;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class DetallesDAL
    {

        public List<DetallesZarcereño> ObtenerDetallesZarcereño(int IdEmpleado)
        {
            List<DetallesZarcereño> detalles = new List<DetallesZarcereño>();
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SP_DetalleApuntesPorOrigen", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", IdEmpleado);
                    cmd.Parameters.AddWithValue("@Origen", "Restaurante");

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            DetallesZarcereño detalle = new DetallesZarcereño()
                            {
                                IdApunte = Convert.ToInt32(dr["IdApunte"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                LugarTrabajo = dr["LugarTrabajo"].ToString(),
                                Origen = dr["Origen"].ToString(),
                                Monto = Convert.ToInt32(dr["Monto"]),
                                Detalle = dr["Detalle"].ToString(),
                                Fecha = Convert.ToDateTime(dr["Fecha"])
                            };
                            detalles.Add(detalle);
                        }
                    }
                }
            }
            return detalles;
        }

        public bool PagarApunte(int idApunte)
        {
            bool resultado = false;
            try
            {

                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_PagarApunte", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdApunte", idApunte);
                        cmd.Parameters.AddWithValue("@Origen", "Restaurante");
                        cmd.Parameters.AddWithValue("@SePagoEn", "Restaurante");

                        cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error al pagar el apunte: " + ex.Message);
            }
            return resultado;
        }
    }
}
