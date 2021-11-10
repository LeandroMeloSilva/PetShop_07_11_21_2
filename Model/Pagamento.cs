using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class Pagamento
    {
        [Key]
        public int PagamentoId { get; set; }
        public DateTime DataPagamento { get; set; }
        [Required]
        public double ValorTotal { get; set; }
        [Required]
        public string CpfCliente { get; set; }
    }
}





       


