using ApuntesTodos.DAL;
using ApuntesTodos.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesTodos.BL
{
    public class HistorialBL
    {

        private HistorialDAL historialDAL = new HistorialDAL();

        public List<Historial> ObtenerHistorial()
        {
                return historialDAL.Historial_ObtenerTodos();
        }

        public List<Historial> BuscarEntreFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            return historialDAL.Historial_BuscarEntreFechas(fechaInicio, fechaFin);
        }
    }
}
