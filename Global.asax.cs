using EczaneFramework.Business.Dependency.Niinject;
using EczaneFramework.Core.Security.Models;
using EczaneFramework.MvcWebUI.CF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Newtonsoft.Json;

namespace EczaneFramework.MvcWebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule()));
        }


        public override void Init()
        {

            PostAuthenticateRequest += MvcApplication_PostAuthenticateRequest;
            base.Init();
        }

        private void MvcApplication_PostAuthenticateRequest(object sender, EventArgs e)
        {

            if (Request.Cookies["Account"] == null)
                return;

            var stringIdentiyt = Request.Cookies["Account"].Value;
            var identity = JsonConvert.DeserializeObject<Identity>(stringIdentiyt);

            //var identity = new Identity();
            //identity.AuthenticationType = "Forms";
            //identity.Email = "husrev@yildiz.com";
            //identity.Name = "Husrev";
            //identity.Soyad = "YILDIZ";
            //identity.Ad = "Hüsrev";
            //identity.Roles = new string[] { "Admin", "User" };

            var principal = new GenericPrincipal(identity, identity.Roles);
            Thread.CurrentPrincipal = principal;

        }
    }
}
