using Principal.Domain;
using Principal.Domain.Repositories;
using Principal.Infra.DatabaseFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using Principal.Domain.Entities;

namespace Principal.Infra.Repositories
{
    public class TestemunhaRepositorio : ITestemunhaRepositorio
    {
        public IDatabaseAdapter DatabaseAdapter { get; }

        public TestemunhaRepositorio(IDatabaseAdapter databaseAdapter)
        {
            DatabaseAdapter = databaseAdapter;
        }

        public void Atualizar(Testemunha testemunha)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Update<Testemunha>(testemunha);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Testemunha ObterTestemunhas()
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = "SELECT  * FROM  [Testemunha] ";
                return conn.Query<Testemunha>(query).FirstOrDefault();

            }
        }
    }
}
