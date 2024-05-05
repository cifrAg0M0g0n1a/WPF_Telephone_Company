using System.Configuration;
using System.Data.Entity;

namespace DBAapp.Models
{
    internal class ApplicationContext : DbContext
    {
        public static string Connection()
        {
            return ConfigurationManager.ConnectionStrings["telephoneCompany"].ConnectionString;
        }
    }
}
