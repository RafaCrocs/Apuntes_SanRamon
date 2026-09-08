using ApuntesEmpleados.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApuntesEmpleados.DAL
{
    public class Conexion
    {
        public static string Cadena = AppConfig.Instance.CadenaConexion;
    }
}
