using ApuntesTodos.DAL;
using ApuntesTodos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesTodos.BL
{
    public class EmpleadosBL
    {
        private EmpleadosDAL empleadosDAL = new EmpleadosDAL();

        public bool Empleado_Insertar(Empleado empleado, out string mensaje)
        {
            return empleadosDAL.Empleados_Insertar(empleado, out mensaje);
        }
    }
}
