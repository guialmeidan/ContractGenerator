using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Services
{
    public interface IPessoaService
    {
        IEnumerable<Pessoa> PesquisarPorNome(string nome);
        void Remover(Pessoa pessoa);
        void Atualizar(Pessoa store);
        void Criar(Pessoa store);
    }
}
