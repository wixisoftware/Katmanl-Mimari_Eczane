using EczaneFramework.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EczaneFramework.Entities.Tables;
using EczaneFramework.DataAccess.DAL.EF;
using EczaneFramework.Core.Security;

namespace EczaneFramework.Business.Concrate
{
    [GenericSecurityAspect]
    public class EczaneYonetimi : IEczane
    {
        public Eczane Add(Eczane eczane)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var result = db.Eczane.Add(eczane);
                db.SaveChanges();
                return result;
            }
        }

        public Eczane Add(string ad, string adres, string yetkili, string mail)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                Eczane _item = new Eczane();
                _item.Ad = ad;
                _item.Adress = adres;
                _item.Mail = mail;
                _item.Yetkili = yetkili;

                var result = db.Eczane.Add(_item);
                db.SaveChanges();
                return result;
            }
        }

        public void Delete(int id)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                var item = db.Eczane.Find(id);
                db.Eczane.Remove(item);
            }
        }

  
        public List<Eczane> GetAll()
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                return db.Eczane.ToList();
            }
        }


        public Eczane GetByID(int Id)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                return db.Eczane.Find(Id);
            }
        }

        public void Update(Eczane eczane)
        {
            using (DatabaseEntities db = new DatabaseEntities())
            {
                db.Entry(eczane).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();                
            }
        }
    }
}
