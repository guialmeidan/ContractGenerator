using Principal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Repositories
{
    public interface ITokenPublicoRepositorio : IDisposable
    {
        TokenPublico ObterToken();
        void Atualizar(TokenPublico escritorio);
    }
}
