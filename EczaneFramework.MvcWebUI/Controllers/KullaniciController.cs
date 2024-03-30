using EczaneFramework.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EczaneFramework.Core.Security;
using System.Threading;
using System.Security.Principal;
using EczaneFramework.Core.Security.Models;
using Newtonsoft.Json;


namespace EczaneFramework.MvcWebUI.Controllers
{
    public class KullaniciController : Controller
    {

        IKullanici _kullaniciServis;

        public KullaniciController(IKullanici kullaniciServis)
        {
            _kullaniciServis = kullaniciServis;
        }
        
        
        // GET: Kullanici
        public ActionResult Index()
        {
            return View(_kullaniciServis.GetAll());
        }

        public ActionResult Login()
        {

            var identity = new Identity();
            identity.AuthenticationType = "Forms";
            identity.Email = "husrev@yildiz.com";
            identity.Name = "Husrev";
            identity.Soyad = "YILDIZ";
            identity.Ad = "Hüsrev";
            identity.Roles = new string[] { "Admin", "User" };

            var stringIdentity = JsonConvert.SerializeObject(identity);
            HttpCookie identityCookie = new HttpCookie("Account", stringIdentity);
           
            Response.Cookies.Add(identityCookie);
           
            



            // _kullaniciServis.GenericIsLogin("husrevyildiz@gmail.com", "123123");


            //ISecurityHelper s = new SessionSecurity();
            //var r = s.GetAccount();
            return View();
        }
    }
}