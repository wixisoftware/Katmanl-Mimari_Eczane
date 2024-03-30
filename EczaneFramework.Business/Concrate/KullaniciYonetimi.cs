using EczaneFramework.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EczaneFramework.Entities.Tables;
using EczaneFramework.DataAccess.DAL.EF;

namespace EczaneFramework.Business.Concrate
{
    public class KullaniciYonetimi : IKullanici
    {
        public Kullanici Add(Kullanici model)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
               var result= db.Kullanici.Add(model);
                db.SaveChanges();
                return result;
            }

           
        }

        public void Delete(int id)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var item = db.Kullanici.Find(id);
                db.Kullanici.Remove(item);
            }
        }

        public List<Kullanici> GetAll()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                return db.Kullanici.ToList();
            }
        }

        public Kullanici GetByID(int Id)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                return db.Kullanici.Find(Id);
            }
        }

        public void Update(Kullanici model)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public bool KullaniciVarmi(string p, string e)
        {
            return true;
        }

        public bool GenericIsLogin(string u, string p)
        {
            throw new NotImplementedException();
        }
    }
}
