using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal.WinApp
{
    public class DescricaoValores
    {
        public DescricaoValores(object id, string name)
        {
            Id = id;
            Name = name;
        }

        public object Id { get; set; }
        public string Name { get; set; }
    }
}
