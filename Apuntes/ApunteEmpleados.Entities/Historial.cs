using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.DAL.BD
{
    public class Historial
    {
        public int IdHistorialPago { get; set; }
        public string NombreCompleto { get; set; }
        public decimal Monto { get; set; }
        public string Detalle { get; set; }
        public string Origen { get; set; }
        public string SePagoEn {  get; set; }
        public DateTime FechaPago { get; set; }
    }
}
