using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Principal.Domain.Entities
{
    [Table("TokenPublico")]
    public class TokenPublico
    {
        [Key]
        public int Id { get; set; }
        public string Token { get; set; }
    }
}
