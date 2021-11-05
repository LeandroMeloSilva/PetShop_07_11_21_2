using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Model
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Um nome é obrigatório!")]
        [Column(TypeName = "nvarchar(100)")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O número do CPF é obrigatório!")]
        [Column(TypeName = "nvarchar(11)")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "O número de telefone é obrigatório!")]
        [Column(TypeName = "nvarchar(9)")]
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
