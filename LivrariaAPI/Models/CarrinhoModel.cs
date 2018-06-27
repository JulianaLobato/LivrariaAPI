using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Models
{
    public class CarrinhoModel
    {
        [Key]
        public int CPFComprador { get; set; }
        [Required]
        public string Nome { get; set; }
        public virtual ICollection<LivroModel> LivrosNoCarrinho { get; set; }
    }
}
