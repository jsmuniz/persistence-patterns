using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Store.Service
{
    public interface IService<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        void Add(TEntity category);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}