using EczaneFramework.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EczaneFramework.Entities.Tables;
using EczaneFramework.DataAccess.DAL.EF.GP;

namespace EczaneFramework.Business.Concrate
{
    public class RoleYonetimiGP : IRol
    {
        IEntityRepository<Rol> _context = new EfEntityRepositoryBase<Rol>();

        public Rol Add(Rol model)
        {
            var r = _context.Add(model);
            return r;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rol> GetAll()
        {
            return _context.GetAll();
        }

        public Rol GetByID(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(Rol eczane)
        {
            throw new NotImplementedException();
        }
    }
}
