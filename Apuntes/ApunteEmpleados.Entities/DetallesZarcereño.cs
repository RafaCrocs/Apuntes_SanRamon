using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.Entities
{
    public class DetallesZarcereño
    {
        public int IdApunte { get; set; }
        public string NombreCompleto { get; set; }
        public string LugarTrabajo { get; set; }
        public string Origen { get; set; }
        public int Monto { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
    }
}
