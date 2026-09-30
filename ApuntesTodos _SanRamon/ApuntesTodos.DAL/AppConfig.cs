using System.Text.Json;

namespace ApuntesTodos.DAL
{
    // Lee ConfigurationFile.json de la carpeta donde esta el .exe
    public class AppConfig
    {
        public string CadenaConexionLocal { get; set; } = "server=localhost ; Database=Apuntes_SanRamon4 ; Integrated Security=True ; TrustServerCertificate=True";

        private static AppConfig? _instance;

        public static AppConfig Instance => _instance ??= Cargar();

        private static AppConfig Cargar()
        {
            string ruta = Path.Combine(AppContext.BaseDirectory, "ConfigurationFile.json");
            if (!File.Exists(ruta))
            {
                return new AppConfig();
            }

            string json = File.ReadAllText(ruta);
            return JsonSerializer.Deserialize<AppConfig>(json, new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new AppConfig();
        }
    }
}
