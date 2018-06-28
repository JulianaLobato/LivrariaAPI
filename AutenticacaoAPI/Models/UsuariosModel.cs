using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutenticacaoAPI.Models
{
    public class UsuariosModel
    {
        [Key]
        public int id;
        [Required]
        public string NomeUsuario;
        [Required]
        public string senha;
        [Email]
        public string email;
    }
}
