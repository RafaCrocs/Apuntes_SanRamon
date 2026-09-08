using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class ApuntesDAL
    {

        public List<Apunte> Apuntes_PorOrigen(string origen, out string mensaje)
        {
            List<Apunte> apuntes = new List<Apunte>();
            mensaje = string.Empty;
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("SP_ObtenerApuntesPorOrigen", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        conn.Open();
                        cmd.Parameters.AddWithValue("@Origen", origen);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Apunte apunte = new Apunte
                                {
                                    IdEmpleado = Convert.ToInt32(reader["IdEmpleado"]),
                                    Empleado = new Empleado
                                    {
                                        NombreCompleto = reader["NombreCompleto"].ToString(),
                                        LugarTrabajo = reader["LugarTrabajo"].ToString()
                                    },
                                    Monto = Convert.ToInt32(reader["MontoTotal"])
                                };
                                apuntes.Add(apunte);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        mensaje = $"Error al conectar con la base de datos: {ex.Message}";
                    }
                }
            }
            return apuntes;
        }

        public bool AgregarApunte(Apunte apunte, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertarApunte", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@IdEmpleado", apunte.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Origen", apunte.Origen);
                    cmd.Parameters.AddWithValue("@Monto", apunte.Monto);
                    cmd.Parameters.AddWithValue("@Detalle", apunte.Detalle);

                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        resultado = cmd.ExecuteNonQuery() > 0;
                        mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        mensaje = $"Error al agregar el apunte: {ex.Message}";
                    }
                }
            }

            return resultado;
        }

        public bool PagarTodoApuntesEmpleado(int idEmpleado, string origen, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                using (SqlCommand cmd = new SqlCommand("SP_PagarTodo", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
                    cmd.Parameters.AddWithValue("@SePagoEn", origen);
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                    try
                    {
                        conn.Open();
                        resultado = cmd.ExecuteNonQuery() > 0;
                        mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                    }
                    catch (Exception ex)
                    {
                        mensaje = $"Error al pagar todos los apuntes: {ex.Message}";
                        Console.WriteLine(mensaje);
                    }
                }
            }
            return resultado;
        }

        public List<Apunte> ObtenerApuntesPorEmpleado(Empleado empleado, string origen, out string mensaje)
        {
            List<Apunte> detallesApunte = new List<Apunte>();
            mensaje = string.Empty;
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_DetalleApuntesPorOrigen", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdEmpleado", empleado.IdEmpleado);
                        cmd.Parameters.AddWithValue("@Origen", origen);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                Apunte apunte = new Apunte()
                                {
                                    IdApunte = Convert.ToInt32(dr["IdApunte"]),
                                    Empleado = new Empleado()
                                    {
                                        NombreCompleto = dr["NombreCompleto"].ToString(),
                                    },
                                    Monto = Convert.ToInt32(dr["Monto"]),
                                    Detalle = dr["Detalle"].ToString(),
                                    Fecha = Convert.ToDateTime(dr["Fecha"])
                                };
                                detallesApunte.Add(apunte);
                            }
                        }
                    }
                }
                return detallesApunte;
            }
            catch (SqlException ex)
            {
                mensaje = "Error al obtener los apuntes: " + ex.Message;
                return new List<Apunte>();
            }
        }

        public bool PagarApunte(int idApunte, string origen, out string mensaje)
        {
            bool resultado = false;
            mensaje = string.Empty;
            try
            {

                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_PagarApunte", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@IdApunte", idApunte);
                        cmd.Parameters.AddWithValue("@SePagoEn", origen);

                        cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 200).Direction = ParameterDirection.Output;

                        int filasAfectadas = cmd.ExecuteNonQuery();
                        mensaje = cmd.Parameters["Mensaje"].Value.ToString();
                        resultado = filasAfectadas > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                mensaje = "Algo malió sal: " + ex.Message;
            }
            return resultado;
        }
    }
}
