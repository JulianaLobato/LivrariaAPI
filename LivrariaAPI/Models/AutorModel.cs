using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Models
{
    public class AutorModel
    {
        [Key]
        public int CPF { get; set; }
        [Required]
        public string Nome { get; set; }
        public virtual ICollection<LivroModel> LivrosPublicados { get; set; }
    }
}
