using Core.Base;
using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Genero : BaseEntity
    {
        public string Nome { get; set; }

        // Relacionamento Muitos para Muitos (Genero -> Livros)
        public ICollection<LivroGenero> LivrosGeneros { get; set; }


    }
}
