using ApuntesTodos.Entities;
using ApuntesTodos.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesTodos.DAL
{
    public class HistorialDAL
    {

        public List<Historial> Historial_ObtenerTodos()
        {
            List<Historial> historial = new List<Historial>();

            string query = "select * from vw_VerHistorialPagosTodos order by FechaPago desc";
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Historial pago = new Historial()
                            {
                                IdHistorialPago = Convert.ToInt32(dr["IdHistorialPago"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Monto = Convert.ToInt32(dr["Monto"]),
                                Detalle = dr["Detalle"].ToString(),
                                Origen = dr["Origen"].ToString(),
                                SePagoEn = dr["SePagoEn"].ToString(),
                                FechaPago = Convert.ToDateTime(dr["FechaPago"])
                            };
                            historial.Add(pago);
                        }
                    }
                }
            }
            return historial;
        }

        public List<Historial> Historial_BuscarEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Historial> historial = new List<Historial>();
            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("sp_BuscarEntreFechas", conn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Historial pago = new Historial()
                            {
                                IdHistorialPago = Convert.ToInt32(dr["IdPago"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Monto = Convert.ToInt32(dr["Monto"]),
                                Detalle = dr["Detalle"].ToString(),
                                Origen = dr["Origen"].ToString(),
                                SePagoEn = dr["SePagoEn"].ToString(),
                                FechaPago = Convert.ToDateTime(dr["FechaPago"])
                            };
                            historial.Add(pago);
                        }
                    }
                }
            }
            return historial;
        }
    }
}
