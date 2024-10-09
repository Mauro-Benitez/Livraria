using Livraria.Core.Base;


namespace Livraria.Core.Entity
{
    public class Cliente : BaseEntity
    {
        public required string Nome { get; set; }

        public string Endereco { get; set; }



        //relacionamento Muitos para Um (Avaliação -> Cliente)
        public ICollection<Avaliacao> Avaliacoes { get; set; }


        //relacionamento Muitos para Um (Pedidos -> Cliente)
        public ICollection<Pedido> Pedidos { get; set; }




    }
}
