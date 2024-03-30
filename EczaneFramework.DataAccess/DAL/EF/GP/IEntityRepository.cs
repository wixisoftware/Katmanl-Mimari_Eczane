using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.DataAccess.DAL.EF.GP
{
    public interface IEntityRepository<T>
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetByID(Expression<Func<T, bool>> filter = null);
    }
}
