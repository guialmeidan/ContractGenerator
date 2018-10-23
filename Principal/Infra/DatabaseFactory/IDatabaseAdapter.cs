using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.DatabaseFactory
{
    public interface IDatabaseAdapter
    {
        void CreateDatabase();
        bool ExistsDatabase();
        IDbConnection GetConnection();
        IDbConnection GetConnection(string connectionString);
        string ConnectionString { get; set; }
    }
}
