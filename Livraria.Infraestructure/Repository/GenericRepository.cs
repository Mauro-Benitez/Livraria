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
        protected DbReadContext _readContext;
        protected DbSet<T> _dbSet;

        public GenericRepository(DbEditContext context, DbReadContext readContext)
        {
            _context = context;
            _dbSet = context.Set<T>();
            _readContext = readContext; 
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
            return _readContext.Set<T>().ToList();  
        }

        public T FindById(long IdItem)
        {
            return _readContext.Set<T>().FirstOrDefault(e => e.Id == IdItem);
        }

        public T Update(T item)
        {
            _context.Set<T>().Any(e => e.Id == item.Id);
            _dbSet.Update(item);
            _context.SaveChanges();

            return item;
        }
    }
}
