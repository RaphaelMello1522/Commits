using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Shared.Models
{
    public class Vagas
    {
        public int Id { get; set; }
        public string Vaga { get; set; }
        public int ValorTecnologias { get; set; }
        public int TecnologiasID { get; set; }

        public Tecnologias tecnologias;
        public Candidato candidatos;
        public ICollection<Candidato> Candidato { get; set; }
    }
}
