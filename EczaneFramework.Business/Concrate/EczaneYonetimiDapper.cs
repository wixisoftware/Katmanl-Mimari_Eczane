using EczaneFramework.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EczaneFramework.Entities.Tables;
using EczaneFramework.DataAccess.DAL.DAPPER;
using EczaneFramework.Core.Security;

namespace EczaneFramework.Business.Concrate
{

    [GenericSecurityAspect]
    public class EczaneYonetimiDapper : IEczane
    {
        EczaneDal _eczaneDal = new EczaneDal();
        public Eczane Add(Eczane eczane)
        {
            throw new NotImplementedException();
        }

        public Eczane Add(string ad, string adres, string yetkili, string mail)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Eczane> GetAll()
        {
            return _eczaneDal.GetList();
        }

        public Eczane GetByID(int Id)
        {
            return _eczaneDal.GetEczaneById(Id);
        }

        public void Update(Eczane eczane)
        {
            throw new NotImplementedException();
        }
    }
}
