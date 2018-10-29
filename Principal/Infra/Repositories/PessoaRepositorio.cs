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
using Principal.WinApp;
using Unity;
using Principal.Domain.Entities;

namespace Principal.Infra.Repositories
{
    public class PessoaRepositorio : IPessoaRepositorio
    {
        public IDatabaseAdapter DatabaseAdapter { get; }

        public PessoaRepositorio(IDatabaseAdapter databaseAdapter)
        {
            DatabaseAdapter = databaseAdapter;
            
        }
        public void Atualizar(Pessoa pessoa)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Update<Pessoa>(pessoa);
            }
        }

        public void Criar(Pessoa pessoa)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Insert<Pessoa>(pessoa);
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pessoa> PesquisarPorNome(string nome)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = $"SELECT  * FROM [Pessoa] Where [Nome] like '%{nome}%' or [Sobrenome] like '%{nome}%' ";
                return conn.Query<Pessoa>(query);
            }
        }

        public IEnumerable<Pessoa> ListarTodasPessoas()
        {

            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = "SELECT  * FROM \"Pessoa\" ";
                return conn.Query<Pessoa>(query);
            }
        }

        public bool VerificarSePessoaEstaEmApproved(int id)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = $"SELECT  * FROM [Approved] Where [IdEP] = '{id}' or [IdResponsavel] = '{id}' or " +
                                                              $"[IdTestemunha1] = '{id}' or [IdTestemunha2] = '{id}'";
                if (conn.Query<Approved>(query).FirstOrDefault() == null)
                    return false;
                else return true;
            }
        }

        public void Remover(Pessoa pessoa)
        {
            
            using (var conn = DatabaseAdapter.GetConnection())
            {
                conn.Delete<Pessoa>(pessoa);
            }
        }

        public Pessoa SelecionarPorId(int id)
        {
            using (var conn = DatabaseAdapter.GetConnection())
            {
                var query = $"SELECT  * FROM [Pessoa] Where [Id] = '{id}'";
                return conn.Query<Pessoa>(query).FirstOrDefault(); ;
            }
        }
    }
}
