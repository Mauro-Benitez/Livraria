using Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infraestructure.Repository.Mapping
{
    public class LivroEstoqueMap : IEntityTypeConfiguration<LivroEstoque>
    {
        public void Configure(EntityTypeBuilder<LivroEstoque> builder)
        {
            // Nome da tabela
            //builder.ToTable("LivrosEstoque");

            //// Chave primária
            //builder.HasKey(le => le.Id); 
             
        }
    }

}
