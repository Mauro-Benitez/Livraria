using Livraria.Core.Base;
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
    public class GenericRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected DbEditContext _context;
        protected DbSet<T> _dbSet;

        public GenericRepository(DbEditContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T Create(T item)
        {
            try
            {
                item.DataCriacao = null;               
                _dbSet.Add(item);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
           
            return item;
        }

        public void Delete(long id)
        {
           _dbSet.Remove(FindById(id));
            _context.SaveChanges();
        }

        public List<T> FindAll()
        {
            return _dbSet.ToList();
        }

        public T FindById(long IdItem)
        {
            return _dbSet.FirstOrDefault(e => e.Id.Equals(IdItem));
        }

        public T Update(T item)
        {
            _dbSet.Update(item);
            _context.SaveChanges();

            return item;
        }
    }
}
