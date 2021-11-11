using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class Agendamento
    {
        [Key]
        public int AgendamentoId { get; set; }
        public DateTime DataHora { get; set; }
        [Required]
        public string CpfCliente { get; set; }
        [Required]
        public string NomeServico { get; set; }
    }
}





      


