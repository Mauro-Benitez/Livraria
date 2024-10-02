using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class LivroGenero
    {

        // Tabela associativa para o relacionamento Muitos para Muitos (Livro -> Genero)
        public int IdLivro { get; set; }    
        public Livro Livro { get; set; }


        public int IdGenero { get; set; }
        public Genero Genero { get; set; }

    }
}
