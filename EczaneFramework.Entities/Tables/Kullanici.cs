using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.Entities.Tables
{
    public class Kullanici
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
