using System;
using Core.Base;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades
{
    public class Livro : BaseEntity
    {
        public required string Titulo { get; set; }

        public decimal Preco { get; set; }

        //relacionamento Um para Muitos (Livro -> Autor)
        public Autor Autor { get; set; }
        public int IdAutor { get; set; }

        //relacionamento Muitos para Muitos (Livro -> Genero)
        ICollection<LivroGenero> LivroGeneros { get; set; }


        //relacionamento Muitos para Um (Avaliação -> Livro)
        public ICollection<Avaliacao> Avaliacoes { get; set; }

               
    }
}
