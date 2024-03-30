using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.DataAccess.DAL.EF.GP
{
    public class EfEntityRepositoryBase<T> : IEntityRepository<T> where T : class
    {
        private DatabaseEntities  _context = new DatabaseEntities();
        private DbSet<T> _dbSet;
        
        public EfEntityRepositoryBase()
        {
            
            _dbSet = _context.Set<T>();
        }
        
        public T Add(T entity)
        {
           var result= _dbSet.Add(entity);
            _context.SaveChanges();
            return result;
        }

        //silme metodu eklendi
        public void Delete(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _dbSet.ToList();
        }
        // id parametresine göre cekme işlemi eklendi
        public T GetByID(Expression<Func<T, bool>> filter = null)
        {
            return _context.Set<T>().SingleOrDefault(filter);
        }
        // nesnelerin güncellenmesi eklendi
        public void Update(T entity)
        {
            _context.Entry<T>(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
