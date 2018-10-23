using Principal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Principal.Domain.Entities.Opportunity;

namespace Principal.Domain.Repositories
{
    public interface IOpportunityRepository
    {
        MainOpportunity ObterPorId(int id, string token);
    }
}
