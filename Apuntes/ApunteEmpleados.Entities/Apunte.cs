using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.Entities
{
    public class Apunte
    {
        public int IdApunte { get; set; }
        public string Origen { get; set; }
        public int IdEmpleado { get; set; }

        public Empleado Empleado { get; set; }
        public int Monto { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
    }
}
