using ApunteEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class EmpleadosDAL
    {

        public List<Empleado> Empleados_ObtenerTodos()
        {
            List<Empleado> empleados = new List<Empleado>();

            string query = "Select * from Empleados order by NombreCompleto";

            using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Empleado emp = new Empleado()
                            {
                                IdEmpleado = Convert.ToInt32(dr["IdEmpleado"]),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                LugarTrabajo = dr["LugarTrabajo"].ToString()
                            };
                            empleados.Add(emp);
                        }
                    }
                }
            }
            return empleados;
        }

        public bool Empleados_Insertar(Empleado empleado, out string mensaje)
        {
            mensaje = string.Empty;
            bool resultado = false;
            try
            {
                using (SqlConnection conn = new SqlConnection(Conexion.Cadena))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("SP_InsertarEmpleado", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@NombreCompleto", empleado.NombreCompleto);
                        cmd.Parameters.AddWithValue("@LugarTrabajo", empleado.LugarTrabajo);

                        cmd.Parameters.Add("@Resultado", SqlDbType.Bit).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 255).Direction = ParameterDirection.Output;

                        cmd.ExecuteNonQuery();

                        resultado = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                        mensaje = cmd.Parameters["@Mensaje"].Value.ToString();

                        return resultado;

                    }
                }
            }
            catch (Exception ex)
            {
                mensaje = $"Error al insertar el empleado: {ex.Message}";
                return false;
            }
        }
    }
}
