using Livraria.Core.Base;


namespace Livraria.Core.Entity
{
    public class Avaliacao : BaseEntity
    {
        public required int Nota { get; set; }
        public string Comentario { get; set; }
        public DateTime DataAvalicao { get; set; }


        //relacionamento Muitos para Um (Avaliacao -> Livro)
        public int IdLivro { get; set; }
        public Livro Livro { get; set; }


        //relacionamento Muitos para Um (Cliente -> Avaliacao)

        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
    }
}
