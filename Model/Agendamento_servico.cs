using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class Agendamento_servico
    {
        [Key]
        public int Agendamento_servicoId { get; set; }

        [ForeignKey("AgendamentoId")]
        public string AgendamentoId { get; set; }

        public virtual Animal Animal { get; set; }

        [ForeignKey("ServicoId")]
        public string ServicoId { get; set; }

        public virtual Servico Servico { get; set; }

        public int Quantidade_servicos { get; set; }
        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Valor { get; set; }





    }
}
