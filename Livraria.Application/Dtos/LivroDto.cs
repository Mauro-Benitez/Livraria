using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Dtos
{
    public class LivroDto
    {
        public required string Titulo { get; set; }
        public required decimal Preco { get; set; }      
        public required string Autor { get; set; }
        public DateTime? DataCriacao { get; set; }
    }
}
