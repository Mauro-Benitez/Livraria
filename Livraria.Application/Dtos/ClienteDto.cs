using Livraria.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Livraria.Application.Dtos
{
    public class ClienteDto
    {
        public int? Id { get; set; }
        public required string Nome { get; set; }

        public required string Endereco { get; set; }

        public required string CPF { get; set; }

       
        public ICollection<string>? Avaliacoes { get; set; }

       
        public List<PedidoDto>? PedidosDtos { get; set; }


    }
}
