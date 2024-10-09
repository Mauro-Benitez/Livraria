using Livraria.Core.Base;


namespace Livraria.Core.Entity
{
    public class LivroEstoque : BaseEntity
    {

        //Relacionamento Um para Um (Livro -> LivroEstoque)
        public Livro Livro { get; set; }

        //Chave estrangeira para Livro
        public int IdLivro { get; set; }
        public int Quantidade { get; set; }
    }
}
