using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.Core.Security
{
    public interface ISecurityHelper
    {

        void AccountSet(AccountModel m);

        AccountModel GetAccount();

        string GetUserName();

        bool IsLogin();
        bool IsRole(string roleAdi);
    }
}
