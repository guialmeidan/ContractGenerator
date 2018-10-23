using Principal.Domain.Entities;
using Principal.Domain.Repositories;
using Principal.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Principal.Domain.Entities.Opportunity;

namespace Principal.Infra.Opportunity
{
    public class OpportunityService : IOpportunityService
    {
        private IOpportunityRepository _repository;

        public OpportunityService(IOpportunityRepository repository)
        {
            _repository = repository;
        }



        public MainOpportunity ObterPorId(int id, string token)
        {
            return _repository.ObterPorId(id, token);
        }
    }
}
