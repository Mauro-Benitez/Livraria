using Core.Base;
using Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Pedido : BaseEntity
    {
        public DateTime Data { get; set; }

        public decimal ValorTotal { get; set; }


        public int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; } // Relacionamento Muitos para Um


        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } // Relacionamento Muitos para Um


        public ICollection<ItemPedido> ItensPedido { get; set; } // Navegação
    }
}
