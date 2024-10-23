using Livraria.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Infraestructure.Context
{
    public class DbReadContext:DbContext
    {
        public DbReadContext(DbContextOptions<DbReadContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<LivroEstoque> Estoques { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
