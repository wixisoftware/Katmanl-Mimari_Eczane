using EczaneFramework.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EczaneFramework.Entities.Tables;
using EczaneFramework.DataAccess.DAL.EF.GP;
using EczaneFramework.Core.Security;

namespace EczaneFramework.Business.Concrate
{
    public class EczaneYonetimiGenric : IEczane
    {
        private IEntityRepository<Eczane> _db = new EfEntityRepositoryBase<Eczane>();


        //[SecurityAspect(RolAdi ="User")]
        [GenericSecurityAspect]
        public List<Eczane> GetAll()
        {            
            return _db.GetAll();
        }

        public Eczane Add(Eczane eczane)
        {
            //ISecurityHelper ss = new SessionSecurity();
            //if (!ss.IsLogin())
            //    throw new Exception("Kullanici Girişi Yapılmalı");
            //if(!ss.IsRole("Admin"))
            //    throw new Exception("Bu işlemi yapmaya erişim yetkiniz yok");

            return _db.Add(eczane);
        }

        public Eczane Add(string ad, string adres, string yetkili, string mail)
        {
            //ISecurityHelper ss = new SessionSecurity();
            //if (!ss.IsLogin())
            //    throw new Exception("Kullanici Girişi Yapılmalı");
            //if (!ss.IsRole("Admin"))
            //    throw new Exception("Bu işlemi yapmaya erişim yetkiniz yok");



            Eczane eczane = new Eczane();
            eczane.Ad = ad;
            eczane.Adress = adres;
            eczane.Mail = mail;
            eczane.Yetkili = yetkili;

           return _db.Add(eczane);
        }


        //[SecurityAspect(RolAdi ="Admin")]
        public void Delete(int id)
        {
            //ISecurityHelper ss = new SessionSecurity();
            //if (!ss.IsLogin())
            //    throw new Exception("Kullanici Girişi Yapılmalı");
            //if (!ss.IsRole("Admin"))
            //    throw new Exception("Bu işlemi yapmaya erişim yetkiniz yok");


            var d = this.GetByID(id);
            _db.Delete(d);
        }
         

        public Eczane GetByID(int Id)
        {
            ISecurityHelper ss = new SessionSecurity();
            if (!ss.IsLogin())
                throw new Exception("Kullanici Girişi Yapılmalı");
            return _db.GetByID(h => h.Id==Id);
        }

        public void Update(Eczane eczane)
        {
            _db.Update(eczane);
        }
    }
}
