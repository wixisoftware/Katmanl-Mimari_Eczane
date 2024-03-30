using EczaneFramework.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.Business.Abstract
{
    public interface IEczane
    {
  
        Eczane Add(string ad, string adres, string yetkili, string mail);

        Eczane Add(Eczane eczane);
        void Update(Eczane eczane);
        void Delete(int id);
        List<Eczane> GetAll();
        Eczane GetByID(int Id);

    }
}
