using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Repositories
{
    public interface IPessoaRepositorio: IDisposable
    {
        void Criar(Pessoa pessoa);
        IEnumerable<Pessoa> ListarTodasPessoas();
        IEnumerable<Pessoa> PesquisarPorNome(string pessoa);
        void Atualizar(Pessoa pessoa);
        void Remover(Pessoa pessoa);
        Pessoa SelecionarPorId(int id);
    }
}
