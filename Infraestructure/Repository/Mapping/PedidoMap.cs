using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository.Mapping
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            //builder.ToTable("Livros");

            //// Chave primária
            //builder.HasKey(p => p.Id);

            //// Mapeamento de propriedades
            //builder.Property(p => p.Id)
            //       .HasColumnType("INT")
            //       .UseIdentityColumn();

        
            // Relacionamento um para muitos (Livro => Autor)
            builder.HasOne(p => p.Cliente)
                   .WithMany(a => a.Pedidos)
                   .HasForeignKey(p => p.IdCliente);

            // Relacionamento um para muitos (Livro => Avaliações)
            builder.HasOne(p => p.Livro)
                  .WithMany(a => a.Pedidos)
                  .HasForeignKey(p => p.IdLivro); 

        }
    }
}
