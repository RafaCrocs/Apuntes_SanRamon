using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.Entities
{
    public class VerApuntesZarcereño
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string LugarTrabajo { get; set; }
        public decimal Monto { get; set; }
    }
}
