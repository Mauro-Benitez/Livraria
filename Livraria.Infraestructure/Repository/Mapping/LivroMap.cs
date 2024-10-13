using Livraria.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Livraria.Infraestructure.Repository.Mapping
{
    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            // Nome da tabela
            builder.ToTable("Livros");

            // Chave primária
            builder.HasKey(p => p.Id);

            // Mapeamento de propriedades
            builder.Property(p => p.Id)
                .HasColumnType("INT")
                .UseIdentityColumn();

            builder.Property(p => p.DataCriacao)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(p => p.Titulo)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(p => p.Preco)
                .HasColumnType("DECIMAL")
                .IsRequired();

            // Relacionamento um para muitos (Livro => Autor)
            builder.HasOne(p => p.Autor)
                .WithMany(a => a.Livros)
                .HasForeignKey(p => p.IdAutor);

            // Relacionamento um para um (Livro => Autor)
            builder.HasOne(p => p.LivroEstoque)
                .WithOne(le => le.Livro)
                .HasForeignKey<LivroEstoque>(le => le.IdLivro);
        }
    }
}
