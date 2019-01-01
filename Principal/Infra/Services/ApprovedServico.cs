using Principal.Domain.Entities;
using Principal.Domain.Repositories;
using Principal.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Infra.Services
{
    public class ApprovedServico : IApprovedService
    {
        private IApprovedRepositorio _repository;
        public ApprovedServico(IApprovedRepositorio repository)
        {
            _repository = repository;
        }
        public void Atualizar(Approved approved)
        {
            _repository.Atualizar(approved);
        }

        public void Criar(Approved approved)
        {
            _repository.Criar(approved);
        }

        public IEnumerable<Approved> ListarApproveds()
        {
            return _repository.ListarApproveds();
        }

        public IEnumerable<Approved> PesquisarApproved(string valor)
        {
            return _repository.PesquisarApproved(valor);
        }

        public void Remover(Approved approved)
        {
            _repository.Remover(approved);
        }
    }
}
