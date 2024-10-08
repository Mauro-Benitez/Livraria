using Core.Base;



namespace Core.Entity
{
    public class LivroEstoque : BaseEntity
    {
        // Chave estrangeira para Livro
        public int IdLivro { get; set; }
        public Livro Livro { get; set; } = new Livro();
        public int Quantidade { get; set; }
    }
}
