using Livraria.Core.Base;


namespace Livraria.Core.Entity
{
    public class Autor : BaseEntity
    {
        public required string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        //relacionamento Um para Muitos (Autor -> livro)
        public ICollection<Livro> Livros;
    }
}
