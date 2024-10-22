using Livraria.Application.Dtos;
using Livraria.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Services
{
    public interface IClienteService
    {
        ClienteDto Create(ClienteDto item);
        ClienteDto FindClinteById(long IdItem);
        ClienteDto Update(ClienteDto item);
        List<ClienteDto> FindAll();
        void Delete(long IdItem);
        ClienteDto ObterPedidosDoCliente(int id);

    }
}
