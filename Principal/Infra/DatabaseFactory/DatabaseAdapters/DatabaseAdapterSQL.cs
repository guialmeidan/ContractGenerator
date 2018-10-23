using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.DatabaseFactory.DatabaseAdapters
{
    public class DatabaseAdapterSQLite : IDatabaseAdapter
    {
        static string FileNameDb = "geracontrato.db";

        public DatabaseAdapterSQLite()
        {
        }

        public string ConnectionString { get; set; } = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), FileNameDb)};Version=3;Read Only=False;";

        public void CreateDatabase()
        {
            if (!File.Exists(FileNameDb))
                SQLiteConnection.CreateFile(FileNameDb);
        }

        public bool ExistsDatabase()
        {
            return File.Exists(FileNameDb);
        }

        public IDbConnection GetConnection()
        {
            return new SQLiteConnection(ConnectionString);
        }

        public IDbConnection GetConnection(string connectionString)
        {
            return new SQLiteConnection(connectionString);
        }
    }
}
