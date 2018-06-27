using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Models
{
    public class ComentarioModel
    {
        [Key]
        public int LivroISBN { get; set; }

        [Required]
        public int CPFAutorComentario { get; set; }

        [Required]
        public string Comentario { get; set; }
    }
}
