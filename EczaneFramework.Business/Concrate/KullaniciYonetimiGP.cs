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
    public class KullaniciYonetimiGP : IKullanici
    {
        IEntityRepository<Kullanici> _context = new EfEntityRepositoryBase<Kullanici>();

        public Kullanici Add(Kullanici eczane)
        {
            var r =_context.Add(eczane);
            return r;
        }

        public void Delete(int id)
        {
            var r = _context.GetByID(h => h.Id == id);
            _context.Delete(r);
        }

        public List<Kullanici> GetAll()
        {
            
            return _context.GetAll();
        }

        public Kullanici GetByID(int Id)
        {
            return _context.GetByID(h => h.Id == Id);
        }

        public void Update(Kullanici k)
        {
            _context.Update(k);
        }


        /// <summary>
        /// Sadece web taraflı calısan sesion yöntemi metodu
        /// </summary>
        /// <param name="p"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool KullaniciVarmi(string p, string e)
        {
            //kullancii sorglandı kullanacı var

           
            AccountModel accounModel = new AccountModel();
            accounModel.Ad = "Hüsrev";
            accounModel.Email = "a@a.com";

            accounModel.Roller = new List<Core.Security.Rol>()
            {
                new Core.Security.Rol()
                {
                    Id=1,Ad="Admin",
                },
                // new Core.Security.Rol()
                //{
                //    Id=2,Ad="User"
                //}
            };

            ISecurityHelper sh = new SessionSecurity();
            sh.AccountSet(accounModel);


            return true;
        }

        public bool GenericIsLogin(string u, string p)
        {

            ISecurityHelper _security = new GenericPrincipalSecurity();
            var user = _context.GetByID(h => h.KullaniciAdi == u && h.Sifre == p);
            if (user != null)
            {
                AccountModel ac = new AccountModel();
                ac.Ad = "Hüsrev";
                ac.Soyad = "YILDIZ";
                ac.Email = u;
                ac.Id = user.Id;

                _security.AccountSet(ac);
                return true;
            }

            return false;
           
        }
    }
}
