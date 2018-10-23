using Principal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Repositories
{
    public interface IApprovedRepositorio : IDisposable
    {
        void Criar(Approved pessoa);
        IEnumerable<Approved> ListarApproveds();
        IEnumerable<Approved> PesquisarApproved(string valor);
        void Atualizar(Approved approved);
        void Remover(Approved approved);
    }
}