using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ApuntesElJardin.Utils
{
    public class Formato
    {

        private static CultureInfo cultureInfo = new CultureInfo("es-CR");
        public static string ConvertirMontoAMoneda(object monto)
        {
            return Convert.ToInt32(monto).ToString("C0", cultureInfo);
        }
    }
}
