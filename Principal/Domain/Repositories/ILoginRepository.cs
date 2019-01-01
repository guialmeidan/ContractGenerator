using Principal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Repositories
{
    public interface ILoginRepository
    {
        Login ObterPorId(int id);
        bool IsAuthenticated { get; set; }
    }
}
