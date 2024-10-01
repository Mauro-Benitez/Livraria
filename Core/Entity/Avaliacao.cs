using Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entidades
{
   public class Avaliacao : BaseEntity
    {
        public int Nota { get; set; }
        public string Comentario { get; set; }
        public DateTime DataAvalicao { get; set; }


        //relacionamento Muitos para Um (Avaliacao -> Livro)
        public int IdLivro { get; set; }
        public Livro Livro { get; set; }
        

        //relacionamento Muitos para Um (Cliente -> Avaliacao)

        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }



    }
}
