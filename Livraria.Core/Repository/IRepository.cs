using Livraria.Core.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Core.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {

        T Create(T item);
        T FindById(long IdItem);
        T Update(T item);
        List<T> FindAll();
        void Delete(long IdItem);    
      

    }
}
