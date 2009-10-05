using System.Data;

namespace DesignPatterns.DataAccess
{
    public interface IDbProviderFactory
    {
        IDbConnection CreateConnection();
        IDbCommand CreateCommand();
    }
}
