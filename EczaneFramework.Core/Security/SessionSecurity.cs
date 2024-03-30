using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace EczaneFramework.Core.Security
{
    [Serializable]
    public class SessionSecurity  : ISecurityHelper
    {
        private  string userSession = "user";

        public  void AccountSet(AccountModel m)
        {
            HttpContext.Current.Session[userSession] = m;
        }

        public  AccountModel GetAccount()
        {
            if (HttpContext.Current.Session[userSession] == null)
                throw new Exception("Kullanıcı Bulunamadı");
            return ((AccountModel)HttpContext.Current.Session[userSession]);
        }

        public  string GetUserName()
        {
            return GetAccount().Email;
        }

        public  bool IsLogin()
        {
            return (HttpContext.Current.Session[userSession] != null);
        }

        public  bool IsRole(string roleAdi)
        {
            /// Accountmodel uzerindeki rol listesinden rol sorgulama işlemleri
            var user = GetAccount();
            return user.Roller.Any(h=>h.Ad.Equals(roleAdi));
        }
    }
}
