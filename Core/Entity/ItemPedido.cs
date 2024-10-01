using Core.Base;
using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class ItemPedido : BaseEntity
    {

        public int Id { get; set; }
        public int Quantidade { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; } // Relacionamento Muitos para Um

        public int LivroId { get; set; }
        public Livro Livro { get; set; } // Relacionamento Muitos para um


    }
}
