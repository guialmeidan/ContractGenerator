using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Entities
{
    //Classe que recebe objeto para registro do approved em API
    public class RegistroApproved
    {
        public DateTime DataCriacao { get; set; }
        public string NomeCL { get; set; }
        public int Programa { get; set; }
    }
}
