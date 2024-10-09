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
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            // Nome da tabela
            builder.ToTable("Cliente");

            // Chave primária
            builder.HasKey(p => p.Id);

            // Mapeamento de propriedades
            builder.Property(p => p.Id).HasColumnType("INT").UseIdentityColumn();
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(500)").IsRequired();
            builder.Property(p => p.Endereco).HasColumnType("VARCHAR(500)").IsRequired();

        }
    }
}
