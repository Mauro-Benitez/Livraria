using Livraria.Core.Entity;
using Livraria.Core.Repository;
using Livraria.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Infraestructure.Repository
{
    class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(DbEditContext context, DbReadContext readContext) : base(context, readContext)
        {
        }

        public Cliente ObterPedidosDoCliente(int id)
        {

            var cliente = _readContext.Clientes
                .Include(c => c.Pedidos)
                    .ThenInclude(p => p.Livro)
                    .ThenInclude(l => l.AutorLivro)
                .FirstOrDefault(c => c.Id == id) ?? throw new Exception("Esse cliente não existe");


            return cliente;
        }
    }
}
