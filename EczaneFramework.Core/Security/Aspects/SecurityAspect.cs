using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EczaneFramework.Core.Security
{
    [Serializable]
    public class SessionSecurityAspect  : OnMethodBoundaryAspect
    {
        public string RolAdi { get; set; }

       SessionSecurity _securityHelper = new SessionSecurity();
        public override void OnEntry(MethodExecutionArgs args)
        {

            if (!_securityHelper.IsLogin())
                throw new Exception("Kullanici Girişi Yapılmalı");


            if (!string.IsNullOrEmpty(RolAdi) && !_securityHelper.IsRole(RolAdi))
                throw new Exception("Bu işlemi yapmaya erişim yetkiniz yok");

            base.OnEntry(args);
        }
    }

    [Serializable]
    public class GenericSecurityAspect : OnMethodBoundaryAspect
    {
        public string RolAdi { get; set; }

       
        public override void OnEntry(MethodExecutionArgs args)
        {

            if (string.IsNullOrEmpty(Thread.CurrentPrincipal.Identity.Name))
                throw new Exception("Kullanici Girişi Yapılmalı");

            //Thread.CurrentPrincipal.IsInRole()
            //if (!string.IsNullOrEmpty(RolAdi) && !_securityHelper.IsRole(RolAdi))
            //    throw new Exception("Bu işlemi yapmaya erişim yetkiniz yok");

            base.OnEntry(args);
        }
    }
}
