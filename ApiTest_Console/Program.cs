using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GetOperation();
            PostOperation();
           

        }

        private static void PostOperation()
        {
            var client = new RestClient("http://localhost:53629/api/Eczane/");


            var req = new RestRequest(Method.GET);
            Eczane ecz = new Eczane();
            ecz.Id = 99;
            ecz.Ad = "Güzeller";

            req.AddJsonBody(ecz);

            var result = client.Execute(req);
            
            if (result.ContentLength > 0)
            {
                Console.WriteLine(result.Content.ToString());
            }

            Console.ReadLine();
        }

        public class Eczane
        {
            public int Id { get; set; }
            public string Ad { get; set; }
            public string Adress { get; set; }
            public string Telefon { get; set; }
            public string Yetkili { get; set; }
            public string Mail { get; set; }

        }

        private static void GetOperation()
        {
            var client = new RestClient("http://localhost:53629/api/Eczane/");


            var req = new RestRequest(Method.GET);

            var result = client.Execute(req);

            if (result.ContentLength > 0)
            {
                Console.WriteLine(result.Content.ToString());
            }

            Console.ReadLine();
        }
    }
}
