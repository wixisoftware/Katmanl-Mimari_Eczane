using EczaneFramework.Business.Abstract;
using EczaneFramework.Business.Concrate;
using EczaneFramework.Core.Security;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.Business.Dependency.Niinject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISecurityHelper>().To<GenericPrincipalSecurity>();



            //eger biri I eczane isterse, Ecane yonetimi generc sınıfını gönder
            //Bind<IEczane>().To<EczaneYonetimiGenric>();


            //eger biri IEczane isterse, Eczaneyonetimini gönder
            //Bind<IEczane>().To<EczaneYonetimi>();


            Bind<IEczane>().To<EczaneYonetimiDapper>();





            Bind<IKullanici>().To<KullaniciYonetimiGP>();
            Bind<IRol>().To<RoleYonetimiGP>();
        }
    }
}
