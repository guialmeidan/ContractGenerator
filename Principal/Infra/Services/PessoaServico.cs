using Principal.Domain;
using Principal.Domain.Repositories;
using Principal.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Services
{
    public class PessoaServico : IPessoaService
    {
        private IPessoaRepositorio _repository;
        public PessoaServico(IPessoaRepositorio repository)
        {
            _repository = repository;
        }
        public void Criar(Pessoa pessoa)
        {
            _repository.Criar(pessoa);
        }

        public IEnumerable<Pessoa> PesquisarPorNome(string nome)
        {
            return _repository.PesquisarPorNome(nome);
        }

        public void Remover(Pessoa pessoa)
        {
            _repository.Remover(pessoa);
        }

        public void Atualizar(Pessoa pessoa)
        {
            _repository.Atualizar(pessoa);
        }
    }
}
