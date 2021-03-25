using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> 
        where T: class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
