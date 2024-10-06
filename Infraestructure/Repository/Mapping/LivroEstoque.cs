using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infraestructure.Repository.Mapping
{
    public class LivroEstoque : IEntityTypeConfiguration<LivroEstoque>
    {
        public void Configure(EntityTypeBuilder<LivroEstoque> builder)
        {
           
        }
    }
}
