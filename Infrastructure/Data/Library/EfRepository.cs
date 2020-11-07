using ApplicationCore.Interfaces.Library;
using Infrastructure.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Infrastructure.Data.Library
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly SampleContext _context;

        public EfRepository(SampleContext context)
        {
            _context = context;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate);
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public TEntity FindOne(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Find(predicate);
        }

        public void Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _context.Set<TEntity>().RemoveRange(entities);
        }
        public void Update(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
