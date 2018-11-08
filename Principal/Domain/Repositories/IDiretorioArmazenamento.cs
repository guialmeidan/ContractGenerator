using Principal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Repositories
{
    public interface IDiretorioArmazenamentoRepositorio : IDisposable
    {
        DiretorioArmazenamento ObterCaminho();
        void Atualizar(DiretorioArmazenamento caminho);
    }
}
