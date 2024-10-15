using Livraria.Core.Entity;
using Livraria.Core.Repository;
using Livraria.Infraestructure.Context;

namespace Livraria.Infraestructure.Repository
{
    public class LivroRepository: GenericRepository<Livro>, ILivroRepository
    {
        public LivroRepository(DbEditContext context) : base(context)
        {
        }

        
    }
}
