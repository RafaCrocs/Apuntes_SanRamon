using ApuntesTodos.DAL;

namespace ApuntesTodos.BL
{
    public class LugaresTrabajoBL
    {
        private readonly LugaresTrabajoDAL lugaresTrabajoDAL = new();

        public List<string> Lugares_ObtenerTodos(out string mensaje)
        {
            return lugaresTrabajoDAL.Lugares_ObtenerTodos(out mensaje);
        }
    }
}
