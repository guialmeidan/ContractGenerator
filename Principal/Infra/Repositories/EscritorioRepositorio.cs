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
    public class EscritorioRepositorio : IEscritorioRepositorio
    {
        public IDatabaseAdapter DatabaseAdapter { get; }

        public EscritorioRepositorio(IDatabaseAdapter databaseAdapter)
        {
            DatabaseAdapter = databaseAdapter;
        }

        public void Atualizar(Escritorio escritorio)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Update<Escritorio>(escritorio);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Escritorio ObterEscritorio()
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = "SELECT  * FROM  [Escritorio] ";
                return conn.Query<Escritorio>(query).FirstOrDefault();
                
            }
        }

        public bool VerificarSeELCP(int id)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = $"SELECT  * FROM [Escritorio] Where [LCP] = '{id}'";
                if (conn.Query<Escritorio>(query).FirstOrDefault() == null)
                    return false;
                else return true;
            }
        }
    }
}
