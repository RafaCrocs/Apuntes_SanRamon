using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class HistorialDAL
    {

        public List<Historial> Historial_ObtenerTodos(string origen, out string mensaje)
        {
            List<Historial> historial = new List<Historial>();
            mensaje = string.Empty;
            try
            {

                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_HistorialPagosPorOrigen", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Origen", origen);

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
            catch ( SqlException ex )
            {
                mensaje =  "Error al obtener el historial: "  + ex.Message;
                return new List<Historial>() { new Historial() { NombreCompleto = "No se cargaron los datos" } };
            }
        }
    }
}
