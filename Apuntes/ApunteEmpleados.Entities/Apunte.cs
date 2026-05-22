using System;
using System.Collections.Generic;
using System.Text;

namespace ApunteEmpleados.Entities
{
    public class Apunte
    {
        public int IdApunte { get; set; }
        public string Origen { get; set; }
        public int IdEmpleado { get; set; }
        public int Monto { get; set; }
        public string Detalle { get; set; }
        public DateTime Date { get; set; }
    }
}
