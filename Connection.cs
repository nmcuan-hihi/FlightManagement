using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VnAirLines
{
    internal static class Connection
    {
        public static SqlConnection Connect()
        {
            Env.Load();
            //string connectionString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            string host = Environment.GetEnvironmentVariable("HOST");
            string db = Environment.GetEnvironmentVariable("DB");
            string connectionString = $"Data Source={host};Initial Catalog={db};Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
