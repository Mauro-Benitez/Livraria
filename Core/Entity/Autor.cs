using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Autor : BaseEntity
    {
        public required string Nome {  get; set; }

        public DateTime DataNascimento { get; set; }

        //relacionamento Um para Muitos (Autor -> livro)
        ICollection<Livro> livros;
    }
}
