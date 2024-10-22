using Livraria.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Dtos
{
    public class PedidoDto
    {
         public int? Id { get; set; }
        public int IdCliente { get; set; }     
        public ClienteDto ClienteDto { get; set; }
        public int IdLivro { get; set; }        
        public LivroDto LivroDto { get; set; }

        
    }
}
