using ApuntesEmpleados.Entities;
using ApuntesEmpleados.DAL.BD;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ApuntesEmpleados.BL
{
    public class EmpleadosBL
    {

        private EmpleadosDAL empleadosDAL = new EmpleadosDAL();

        public List<Empleado> Empleados_ObtenerTodos(out string mensaje)
        {
            return empleadosDAL.Empleados_ObtenerTodos(out mensaje);
        }

        public bool Empleado_Insertar(Empleado empleado, out string mensaje)
        {
            if( empleado.NombreCompleto == null)
            {
                mensaje = "El nombre del colaborador no pueden ser nulos.";
                return false;
            }

            if(empleado.LugarTrabajo == null)
            {
                mensaje = "Indique el lugar de trabajo del colaborador.";
                return false;
            }

            return empleadosDAL.Empleados_Insertar(empleado, out mensaje);
        }

    }
}
