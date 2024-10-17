using Livraria.Core.Base;


namespace Livraria.Core.Entity
{
    public class Livro : BaseEntity
    {

        public required string Titulo { get; set; }

        public required decimal Preco { get; set; }

        //relacionamento Um para Muitos (Livro -> Autor)
        public  Autor AutorLivro { get; set; }

        //Chave estrangeira para autor
        public  int IdAutor { get; set; }


        //relacionamento Muitos para Um (Avaliação -> Livro)
        public ICollection<Avaliacao> Avaliacoes { get; set; }


        //relacionamento Muitos para Um (Livro -> Pedidos)
        public ICollection<Pedido> Pedidos { get; set; }

        //relacionamento um para um (livro -> estoque)
        public LivroEstoque LivroEstoque { get; set; }


      

        
    }
}
