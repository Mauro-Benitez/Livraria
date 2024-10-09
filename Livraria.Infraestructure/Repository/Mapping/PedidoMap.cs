using Livraria.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Livraria.Infraestructure.Repository.Mapping
{
    public class PedidoMap : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");

            // Chave primária
            builder.HasKey(p => p.Id);

            // Mapeamento de propriedades
            builder.Property(p => p.Id)
                   .HasColumnType("INT")
                   .UseIdentityColumn();


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
