using Livraria.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Services
{
    public interface IPedidoService
    {
        PedidoDto Create(PedidoDto item);
        PedidoDto FindById(long IdItem);
        PedidoDto Update(PedidoDto item);
        List<PedidoDto> FindAll();
        void Delete(long IdItem);
    }
}
