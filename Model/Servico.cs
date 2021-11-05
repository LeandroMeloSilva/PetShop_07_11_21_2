using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class Servico
    {
        [Key]
        public int ServicoId { get; set; }

        public string Descricao { get; set; }

        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Valor { get; set; }

        public float Duracao { get; set; }



    }
}
