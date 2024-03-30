using EczaneFramework.Core.Security.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EczaneFramework.Core.Security
{
    public class GenericPrincipalSecurity : ISecurityHelper
    {
        public void AccountSet(AccountModel m)
        {

            var identity = new Identity();
            identity.AuthenticationType = "Forms";
            identity.Email = m.Email;
            identity.Name = m.Ad;
            identity.Soyad = m.Soyad;
            identity.Ad = m.Ad;
            identity.Roles = new string[] { "Admin", "User" };
            var principal = new GenericPrincipal(identity,identity.Roles);
            Thread.CurrentPrincipal = principal;

        }

        public AccountModel GetAccount()
        {
            throw new NotImplementedException();
        }

        public string GetUserName()
        {
            throw new NotImplementedException();
        }

        public bool IsLogin()
        {
            throw new NotImplementedException();
        }

        public bool IsRole(string roleAdi)
        {
            throw new NotImplementedException();
        }
    }
}
