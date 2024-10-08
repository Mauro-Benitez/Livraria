using System;
using Core.Base;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Livro : BaseEntity
    {
        public string Titulo { get; set; }

        public decimal Preco { get; set; }

        //relacionamento Um para Muitos (Livro -> Autor)
        public Autor Autor { get; set; }

        //Chave estrangeira para autor
        public int IdAutor { get; set; }

       
        //relacionamento Muitos para Um (Avaliação -> Livro)
        public ICollection<Avaliacao> Avaliacoes { get; set; }


        //relacionamento Muitos para Um (Livro -> Pedidos)
        public ICollection<Pedido> Pedidos { get; set; }

        //relacionamento um para um (livro -> estoque)
        public LivroEstoque LivroEstoque { get; set; }
    }
}
