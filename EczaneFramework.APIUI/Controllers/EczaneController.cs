using EczaneFramework.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EczaneFramework.APIUI.Controllers
{
    public class EczaneController : ApiController
    {
        List<Eczane> fakeData = new List<Eczane>()
            {
                new Eczane { Id=15,Ad="eczane 1" },
                new Eczane { Id=16,Ad="eczane 2" },
                new Eczane { Id=17,Ad="eczane 3" }
                
            };


        [HttpGet]
        public List<Eczane> Get()
        {
            return fakeData;
        }
      

        [HttpPut]
        public Eczane Post(int Id)
        {
            return fakeData.FirstOrDefault(h => h.Id == Id);
        }

        [HttpPost]
        public Eczane Add(Eczane eczane)
        {
            return eczane;
        }

        [HttpDelete]
        public Eczane Delete(Eczane eczane)
        {
            return eczane;
        }

    }
}
