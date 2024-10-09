using Livraria.Core.Entity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace Livraria.Infraestructure.Context
{
    public class DbEditContext : DbContext
    {
        public DbEditContext(DbContextOptions<DbEditContext> options) : base(options)
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
