using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Principal.Domain.Entities
{
    [Table("DiretorioArmazenamento")]
    public class DiretorioArmazenamento
    {
        [Key]
        public int Id { get; set; }
        public string Caminho { get; set; }
    }
}
