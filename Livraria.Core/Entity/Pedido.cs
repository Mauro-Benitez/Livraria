using Livraria.Core.Base;


namespace Livraria.Core.Entity
{
    public class Pedido : BaseEntity
    {

        // Relacioanamento um para muitos (Clientes => Pedido )
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }


        public int IdLivro { get; set; }
        public Livro Livro { get; set; }

    }
}
