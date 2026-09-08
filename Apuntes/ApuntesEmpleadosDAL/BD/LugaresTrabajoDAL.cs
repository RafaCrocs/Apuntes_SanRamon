using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class LugaresTrabajoDAL
    {
        public List<LugaresTrabajo> Lugares_ObtenerTodos(out string mensaje)
        {
            List<LugaresTrabajo> lugares = new List<LugaresTrabajo>();
            mensaje = string.Empty;

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                try
                {

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_ObtenerLugaresTrabajo", conn))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                LugaresTrabajo lugar = new LugaresTrabajo()
                                {
                                    NombreLugarTrabajo = dr["NombreLugarTrabajo"].ToString()
                                };
                                lugares.Add(lugar);
                            }
                        }
                    }
                    return lugares;
                }
                catch (SqlException ex)
                {
                    mensaje = "Error al obtener los lugares de trabajo: " + ex.Message;
                    return new List<LugaresTrabajo>() { new LugaresTrabajo() { NombreLugarTrabajo = "No se cargaron los datos" } };
                }
            }
        }
    }
}
