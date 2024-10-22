using Livraria.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Services
{
    public interface IAutorService
    {
        AutorDto Create(AutorDto item);
        AutorDto FindById(long IdItem);
        AutorDto Update(AutorDto item);
        List<AutorDto> FindAll();
        void Delete(long IdItem);

    }
}
