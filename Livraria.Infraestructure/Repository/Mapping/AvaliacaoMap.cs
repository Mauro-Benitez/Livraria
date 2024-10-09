using Livraria.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Infraestructure.Repository.Mapping
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
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



            //// Relacionamento um para muitos (Livro => Avaliações)
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
