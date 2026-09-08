using ApuntesEmpleados.DAL.BD;
using ApuntesEmpleados.Utils;
using ApuntesEmpleados.Entities;

namespace ApuntesEmpleados.BL
{
    public class HistorialBL
    {

        private HistorialDAL historialDAL = new HistorialDAL();

        public List<Historial> Historial_ObtenerTodos(out string mensaje)
        {
            return historialDAL.Historial_ObtenerTodos(AppConfig.Instance.Origen, out mensaje);
        }
    }
}
