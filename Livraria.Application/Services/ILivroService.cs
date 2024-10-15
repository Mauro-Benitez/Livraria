using Livraria.Application.Dtos;
using Livraria.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Application.Services
{
    public interface ILivroService
    {
        LivroDto Create(LivroDto item);
        LivroDto FindById(long IdItem);
        LivroDto Update(LivroDto item);
        List<LivroDto> FindAll();
        void Delete(long IdItem);
    }

    
}
