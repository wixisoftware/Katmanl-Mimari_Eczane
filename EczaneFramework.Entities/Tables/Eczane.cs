using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.Entities.Tables
{
    public class Eczane
    {
        [Key]
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Adress { get; set; }
        public string Telefon { get; set; }
        public string Yetkili { get; set; }
        public string Mail { get; set; }
    }
}
