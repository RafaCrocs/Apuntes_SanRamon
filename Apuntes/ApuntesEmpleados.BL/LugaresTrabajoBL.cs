using ApuntesEmpleados.DAL.BD;
using ApuntesEmpleados.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.BL
{
    public class LugaresTrabajoBL
    {
        private LugaresTrabajoDAL lugaresTrabajoDAL = new LugaresTrabajoDAL();


        public List<LugaresTrabajo> Lugares_ObtenerTodos(out string mensaje)
        {
            return lugaresTrabajoDAL.Lugares_ObtenerTodos(out mensaje);
        }
    }
}
