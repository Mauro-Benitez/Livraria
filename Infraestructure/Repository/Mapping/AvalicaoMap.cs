using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infraestructure.Repository.Mapping
{
    public class AvalicaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
           // Nome da tabela
           builder.ToTable("Avaliacao");

           //Chave primária
           builder.HasKey(p => p.Id);

           // Mapeamento de propriedades
           builder.Property(p => p.Id).HasColumnType("int").UseIdentityColumn();
           builder.Property(p => p.Comentario).HasColumnType("VARCHAR(500)");
           builder.Property(p => p.DataAvalicao).HasColumnType("DATETIME");
           builder.Property(P => P.Nota).HasColumnType("INT").IsRequired();



           // Relacionamento um para muitos (Livro => Avaliações)
           builder.HasOne(p => p.Livro)
                   .WithMany(a => a.Avaliacoes)
                   .HasForeignKey(a => a.IdLivro);


            // Relacionamento um para muitos (Cliente => Avaliações)
            builder.HasOne(p => p.Cliente)
                    .WithMany(a => a.Avaliacoes)
                    .HasForeignKey(a => a.IdCliente);

        }
    }
}
