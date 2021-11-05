using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class Animal
    {
        [Key]
        public int AnimalId { get; set; }
        [Required(ErrorMessage = "Um nome é obrigatório!")]
        [Column(TypeName = "nvarchar(100)")]
        public string Nome_Animal { get; set; }
        public string GeneroAnimal { get; set; }
        public string Agressividade { get; set; }
        [ForeignKey("ClienteId")]
        public string ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("RacaId")]
        public string RacaId { get; set; }
        public virtual Raca Raca { get; set; }

    }
}
