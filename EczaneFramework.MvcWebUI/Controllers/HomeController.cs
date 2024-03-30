using EczaneFramework.Business.Abstract;
using EczaneFramework.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EczaneFramework.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {

        private IEczane _eczaneService;
        public HomeController(IEczane eczaneService)
        {
            _eczaneService = eczaneService;
        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Eczaneler()
        {
            return View(_eczaneService.GetAll());
        }


        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]   
        public ActionResult Create(Eczane eczane)
        {

            _eczaneService.Add(eczane);
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(Eczane eczane)
        {

            _eczaneService.Update(eczane);
            return View();
        }
    }
}