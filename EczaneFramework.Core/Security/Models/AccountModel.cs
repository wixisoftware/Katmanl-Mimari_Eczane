using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.Core.Security
{
    public class AccountModel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public List<Rol> Roller { get; set; }
    }

    public class Rol
    {
        public int Id { get; set; }
        public string Ad { get; set; }       

    }
}
