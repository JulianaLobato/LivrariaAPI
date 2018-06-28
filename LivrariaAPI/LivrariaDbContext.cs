using LivrariaAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LivrariaAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<LivroModel> Livro { get; set; }
        public DbSet<ComentarioModel> Comentario { get; set; }
        public DbSet<AutorModel> Autor { get; set; }
        public DbSet<CarrinhoModel> Carrinho { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LivroModel>()
                .HasKey(p => p.ISBN);
            modelBuilder.Entity<AutorModel>()
                .HasKey(p => p.CPF);
            modelBuilder.Entity<CarrinhoModel>()
                .HasKey(p => p.CPFComprador);
            modelBuilder.Entity<ComentarioModel>()
                .HasKey(p => p.LivroISBN);
        }
    }
}
