using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ApuntesEmpleados.Utils
{
    public class AppConfig
    {
        public string Origen { get; set; } = "Sin Origen";
        public string CadenaConexion { get; set; } = "Sin cadena de conexion a base de datos";

        private static AppConfig _instance;

        public static AppConfig Instance => _instance ??= Cargar();

        private static AppConfig Cargar()
        {
            string ruta = Path.Combine(AppContext.BaseDirectory, "ConfigurationFile.json");
            if (!File.Exists(ruta))
            {
                return new AppConfig();
            }

            string json = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<AppConfig>(json) ?? new AppConfig();
        }
    }
}
