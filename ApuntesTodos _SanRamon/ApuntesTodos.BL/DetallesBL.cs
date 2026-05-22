using ApuntesTodos.DAL;
using ApuntesTodos.Entities;

namespace ApuntesTodos.BL
{
    public class DetallesBL
    {
        private readonly DetallesDAL detallesDAL = new();

        public List<Detalles> Detalles_ObtenerPorEmpleado(int idEmpleado)
        {
            return detallesDAL.Detalles_ObtenerPorEmpleado(idEmpleado);
        }

        public bool PagarApunte(int idApunte, string Origen, out string mensaje)
        {
            return detallesDAL.PagarApunte(idApunte, Origen, out mensaje);
        }
    }
}
