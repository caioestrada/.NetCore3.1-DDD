using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace C.Estudo.DDD.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        T Get(Guid id);
        IList<T> List();
        IList<T> List(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
