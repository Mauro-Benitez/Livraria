using Livraria.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Dtos
{
    public class AutorDto
    {
        public required string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        //relacionamento Um para Muitos (Autor -> livro)
        public ICollection<string> Livros { get; set; }
    }
}
