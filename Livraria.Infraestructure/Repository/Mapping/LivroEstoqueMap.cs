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
    public class LivroEstoqueMap : IEntityTypeConfiguration<LivroEstoque>
    {
        public void Configure(EntityTypeBuilder<LivroEstoque> builder)
        {
            //Nome da tabela
            builder.ToTable("LivrosEstoque");

            // Chave primária
            builder.HasKey(l => l.Id);



        }
    }
}
