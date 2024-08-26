using Core.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.EfCore
{
    public class EfEntityRepository<TEntity, TContext> : IEntityRepository<TEntity> where TEntity : class, IEntity, new() where TContext : DbContext
    {
        private readonly TContext _context;
        public EfEntityRepository(TContext context) { 
            _context = context;
        }
        public void Add(TEntity entity)
        {
           
                var addeditem = _context.Entry(entity);
                addeditem.State = EntityState.Added;
                _context.SaveChanges();
            
        }

        public void Delete(TEntity entity)
        {
         
                
                var deleteditem = _context.Entry(entity);
                deleteditem.State = EntityState.Deleted;
                _context.SaveChanges();
            
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
          
                return _context.Set<TEntity>().Where(filter).FirstOrDefault();
            
        }

        public  ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
          
                return _context.Set<TEntity>().Where(filter).ToList();
            
        }

        public void Update(TEntity entity)
        {
         
                
                var updateitem = _context.Entry(entity);
                updateitem.State = EntityState.Modified;
                _context.SaveChanges();
            
        }
    }
}
