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
using Dapper.Contrib;
using Principal.Conversoes;
using Principal.Domain.Entities;

namespace Principal.Infra.Repositories
{
    public class ApprovedRepositorio : IApprovedRepositorio
    {
        public IDatabaseAdapter DatabaseAdapter { get; }

        public ApprovedRepositorio(IDatabaseAdapter databaseAdapter)
        {
            DatabaseAdapter = databaseAdapter;
        }

        public void Atualizar(Approved approved)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Update<Approved>(approved);
            }
        }

        public void Criar(Approved approved)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Insert<Approved>(approved);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Approved> ListarApproveds()
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = "SELECT  * FROM \"Approved\" ";
                return conn.Query<Approved>(query);
            }
        }

        public IEnumerable<Approved> PesquisarApproved(string valor)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = $"SELECT  * FROM [Approved] Where [NomeEP] like '%{valor}%' or [TNID] like '%{valor}%' or [PaisDestino] like '%{valor}%' or [CidadeDestino] like '%{valor}%' ";
                return conn.Query<Approved>(query);
            }
        }

        public void Remover(Approved approved)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Delete<Approved>(approved);
            }
        }
    }
}
