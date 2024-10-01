using Core.Base;
using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class LivroEstoque : BaseEntity
    {
        //relacionamento Um para Um (Livro -> LivroEstoque)
        public Livro livro { get; set; }

        public int Quantidade { get; set; }


    }
}
