using LivrariaAPI.Interfaces;
using LivrariaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI.Services
{
    public class LivroService
    {
        private ApplicationDbContext _db;

        public LivroService(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<LivroModel> ListarLivros()
        {
            return _db.Livro
                .OrderBy(p => p.TituloLivro.ToList());
        }

        public LivroModel BuscarLivro(int ISBN)
        {
            if (ISBN != null)
            {
                return _db.Livro.Where(
                    p => p.ISBN == ISBN).FirstOrDefault();
            }
            else
                return null;
        }

        public void AdicionarLivro(LivroModel Livro)
        {
            try
            {
                _db.Livro.Add(Livro);
                _db.SaveChanges();
            }
            catch (InvalidCastException e)
            {
                throw new Exception("Erro ao adicionar este livro.", e);
            }
        }

        public void RemoverLivro(int idLivro)
        {
            try
            {
                LivroModel livro = BuscarLivro(idLivro);

                _db.Livro.Remove(livro);
                _db.SaveChanges();

            }
            catch (InvalidCastException e)
            {
                throw new Exception("Não foi possivel remover este livro.", e);
            }
        }


        public void AtualizarLivro(LivroModel livro)
        {            
            try
            {
                LivroModel livroAntigo = _db.Livro.Where(l => l.ISBN == livro.ISBN).FirstOrDefault();

                if (livroAntigo != null)
                {
                    livroAntigo.TituloLivro = livro.TituloLivro;
                    livroAntigo.NomeAutores = livro.NomeAutores;
                    livroAntigo.Preco = livro.Preco;
                    livroAntigo.Prefacio = livro.Prefacio;
                }
            }
            catch (InvalidCastException e)
            {
                throw new Exception("Livro não encontrado.", e);
            }
        }

    }
}
