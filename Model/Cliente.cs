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
        public string Nome { get; set; }
        public string CPF { get; set; }
        [Required(ErrorMessage = "O número de telefone é obrigatório!")]
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string NomeAnimal { get; set; }
        public string NomeRaca { get; set; }
        public string GeneroAnimal { get; set; }
        public string Comportamento { get; set; }

    }
} 
