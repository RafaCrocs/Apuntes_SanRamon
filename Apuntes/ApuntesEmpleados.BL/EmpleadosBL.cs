using ApunteEmpleados.Entities;
using ApuntesEmpleados.DAL.BD;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.BL
{
    public class EmpleadosBL
    {

        private EmpleadosDAL empleadosDAL = new EmpleadosDAL();

        public List<Empleado> Empleados_ObtenerTodos()
        {
            return empleadosDAL.Empleados_ObtenerTodos();
        }

        public bool Empleado_Insertar(Empleado empleado, out string mensaje)
        {
            return empleadosDAL.Empleados_Insertar(empleado, out mensaje);
        }
    }
}
