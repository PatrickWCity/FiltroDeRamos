using System.Configuration;

namespace Filtro_de_Ramos.Modelo
{
    class Connection
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
    }
}