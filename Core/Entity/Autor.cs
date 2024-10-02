using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Autor : BaseEntity
    {
        public required string Nome {  get; set; }

        public DateTime DataNascimento { get; set; }

        //relacionamento Um para Muitos (Autor -> livro)
        public ICollection<Livro> livros;
    }
}
