using System.Data;
using System.Data.SqlClient;

namespace DesignPatterns.DataAccess
{
    public class DbProviderFactory : IDbProviderFactory
    {
        public IDbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public IDbCommand CreateCommand()
        {
            return new SqlCommand();
        }
    }
}