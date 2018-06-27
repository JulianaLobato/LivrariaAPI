using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LivrariaAPI.Models
{
    public class LivroModel 
    {
        [Key]
        public int ISBN { get; set; }

        [Required]
        public string TituloLivro { get; set; }

        [Required]
        public double Preco { get; set; }

        public string Prefacio { get; set; }

        [Required]
        public virtual List<ComentarioModel> NomeAutores { get; set; }

        public virtual List<ComentarioModel> Comentarios { get; set; }

        public LivroModel()
        {
            LivroModel livro = new LivroModel();
        }
    }
}
