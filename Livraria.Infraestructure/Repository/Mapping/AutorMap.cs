﻿using Livraria.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Livraria.Infraestructure.Repository.Mapping
{
    public class AutorMap : IEntityTypeConfiguration<Autor>
    {
        public void Configure(EntityTypeBuilder<Autor> builder)
        {
            // Nome da tabela
            builder.ToTable("Autor");

            // Chave primária
            builder.HasKey(p => p.Id);

            // Mapeamento de propriedades
            builder.Property(p => p.Id)
                .HasColumnType("INT")
                .UseIdentityColumn();

            builder.Property(p => p.DataNascimento)
                .HasColumnType("DATETIME");
        }
    }
}
