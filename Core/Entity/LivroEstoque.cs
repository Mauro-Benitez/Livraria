using Core.Base;



namespace Core.Entity
{
    public class LivroEstoque : BaseEntity
    {
        //relacionamento Um para Um (Livro -> LivroEstoque)
        public Livro Livro { get; set; }

        public int IdLivro { get; set; }
        public int Quantidade { get; set; }


    }
}
