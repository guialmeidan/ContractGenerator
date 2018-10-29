using Dapper;
using Dapper.Contrib.Extensions;
using Principal.Domain.Entities;
using Principal.Domain.Repositories;
using Principal.Infra.DatabaseFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Repositories
{
    public class TokenPublicoRepositorio : ITokenPublicoRepositorio
    {
        public IDatabaseAdapter DatabaseAdapter { get; }

        public TokenPublicoRepositorio(IDatabaseAdapter databaseAdapter)
        {
            DatabaseAdapter = databaseAdapter;
        }

        public void Atualizar(TokenPublico escritorio)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Update<TokenPublico>(escritorio);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TokenPublico ObterToken()
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = "SELECT  * FROM  [TokenPublico] ";
                return conn.Query<TokenPublico>(query).FirstOrDefault();

            }
        }
    }
}
