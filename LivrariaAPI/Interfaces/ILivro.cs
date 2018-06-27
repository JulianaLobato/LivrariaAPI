using LivrariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Interfaces
{
    public interface ILivro
    {
        IEnumerable<LivroModel> ListarLivros { get; }

        ICollection<LivroModel> BuscarLivro(int ISBN);

       // ICollection<LivroModel> FiltroBuscador(string Autor = "", string Titulo = "");

        void AdicionarLivro(LivroModel livro);
        void RemoverLivro(int idLivro);
        void AtualizarLivro(LivroModel livro);        
    }
}
