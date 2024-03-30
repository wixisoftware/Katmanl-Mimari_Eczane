using EczaneFramework.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.Business.Abstract
{
    public interface IKullanici
    {


        Kullanici Add(Kullanici k);
        void Update(Kullanici k);
        void Delete(int id);
        List<Kullanici> GetAll();
        Kullanici GetByID(int Id);

        bool KullaniciVarmi(string p, string e);
        bool GenericIsLogin(string u, string p);
    }
}
