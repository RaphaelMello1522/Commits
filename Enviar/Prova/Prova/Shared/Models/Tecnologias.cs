using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Shared.Models
{
    public class Tecnologias
    {
        public int Id { get; set; }
        public string tecnologia { get; set; }

        public ICollection<Candidato> Candidato { get; set; }
        public ICollection<Vagas> Vagas { get; set; }
    }
}
