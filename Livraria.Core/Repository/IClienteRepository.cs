using Livraria.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Core.Repository
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente ObterPedidosDoCliente(int id);

    }
}
