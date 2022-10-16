using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Repository.Abstract
{
    public interface IRepositoryBase<TEntity>
    {
        public void Create(TEntity entity);
        public List<TEntity> Read(Expression<Func<TEntity,bool>> expression);
        public void Update(TEntity entity);
        public void Delete(TEntity entity);
    }
}
