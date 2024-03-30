using EczaneFramework.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.Business.Abstract
{
    public interface IRol
    {
        Rol Add(Rol m);
        void Update(Rol m);
        void Delete(int id);
        List<Rol> GetAll();
        Rol GetByID(int Id);
    }
}
