using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.Domain.Entities
{
    [Table("Testemunha")]
    public class Testemunha
    {
        [Key]
        public int Id { get; set; }
        public int IdTestemunha1GV { get; set; }
        public string NomeTestemunha1GV { get; set; }
        public int IdTestemunha1GE { get; set; }
        public string NomeTestemunha1GE { get; set; }
        public int IdTestemunha1GT { get; set; }
        public string NomeTestemunha1GT { get; set; }
        public int IdTestemunha2GV { get; set; }
        public string NomeTestemunha2GV { get; set; }
        public int IdTestemunha2GE { get; set; }
        public string NomeTestemunha2GE { get; set; }
        public int IdTestemunha2GT { get; set; }
        public string NomeTestemunha2GT { get; set; }
    }
}
