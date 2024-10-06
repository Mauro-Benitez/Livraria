using System;
using Core.Base;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Cliente : BaseEntity
    {
         public required string Nome { get; set; }

         public string Endereco {  get; set; }

        public ICollection<Avaliacao> Avaliacoes { get; set; }

        public ICollection<Pedido> Pedidos { get; set; }

    }
}
