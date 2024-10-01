using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Fornecedor : BaseEntity
    {

        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string Contato { get; set; }



        public ICollection<Pedidos> Pedidos { get; set; } //Navegação


    }
}
