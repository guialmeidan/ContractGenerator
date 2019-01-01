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
    public class DiretorioArmazenamentoRepositorio : IDiretorioArmazenamentoRepositorio
    {
        public IDatabaseAdapter DatabaseAdapter { get; }

        public DiretorioArmazenamentoRepositorio(IDatabaseAdapter databaseAdapter)
        {
            DatabaseAdapter = databaseAdapter;
        }

        public void Atualizar(DiretorioArmazenamento caminho)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Update<DiretorioArmazenamento>(caminho);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public DiretorioArmazenamento ObterCaminho()
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = "SELECT  * FROM  [DiretorioArmazenamento] ";
                return conn.Query<DiretorioArmazenamento>(query).FirstOrDefault();

            }
        }
    }
}
