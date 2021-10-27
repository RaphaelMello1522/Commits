using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Shared.Models
{
    public class Candidato
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public int idade { get; set; }
        public string endereco { get; set; }
        public string contato { get; set; }
        [Required]
        public string email { get; set; }
        public int vagaID { get; set; }
        public int tecnologiaID { get; set; }

        public Tecnologias tecnologias;
        public Vagas vagas;
    }
}
