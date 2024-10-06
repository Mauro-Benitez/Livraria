using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Pedido : BaseEntity
    {


        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }


        public int IdLivro { get; set; }
        public Livro Livro { get; set; }




    }
}
