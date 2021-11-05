using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class Raca
    {

        [Key]
        public int RacaId { get; set; }

        [Required(ErrorMessage = "Um nome é obrigatório!")]
        public string Nome { get; set; }

        public string? Pais_origem { get; set; }
    }
}
