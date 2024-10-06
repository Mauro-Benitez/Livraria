using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace Infraestructure.Repository.Mapping
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

            builder.HasOne(p => p.LivroEstoque)          // Livro tem um LivroEstoque
            .WithOne(l => l.Livro)                // LivroEstoque tem um Livro
            .HasForeignKey<LivroEstoque>(l => l.IdLivro); // IdLivro é a chave estrangeira em LivroEstoque

        }





    }
}
