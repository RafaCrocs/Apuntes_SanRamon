using ApuntesEmpleados.DAL.BD;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.BL
{
    public class HistorialBL
    {

        private HistorialDAL historialDAL = new HistorialDAL();

        public List<Historial> Historial_ObtenerTodos()
        {
            return historialDAL.Historial_ObtenerTodos();
        }
    }
}
