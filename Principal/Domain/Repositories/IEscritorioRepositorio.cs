using Principal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Repositories
{
    public interface IEscritorioRepositorio : IDisposable
    {
        Escritorio ObterEscritorio();
        void Atualizar(Escritorio escritorio);
    }
}
