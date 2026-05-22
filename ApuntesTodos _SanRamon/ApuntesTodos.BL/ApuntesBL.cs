using ApuntesTodos.DAL;
using ApuntesTodos.Entities;

namespace ApuntesTodos.BL
{
    public class ApuntesBL
    {

        private ApuntesDAL apuntesDAL = new ApuntesDAL();

        public List<Apuntes> Apuntes_ObtenerTodos()
        {
            return apuntesDAL.Apuntes_ObtenerTodos();
        }

        public bool PagarApuntesSalario(int IdEmpleado)
        {
            return apuntesDAL.PagarApuntesSalario(IdEmpleado);
        }

    }
}
