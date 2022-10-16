using Core.Repository.Abstract;
using Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Repository
{
    public class EfRepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Create(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var createdEntity = context.Entry(entity);
                createdEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext() )
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<TEntity> Read(Expression<Func<TEntity, bool>> expression=null)
        {
            using (TContext context = new TContext())
            {
                return expression == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(expression).ToList();
            } 
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
