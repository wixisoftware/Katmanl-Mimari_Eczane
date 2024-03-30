using EczaneFramework.DataAccess.DAL.DAPPER;
using EczaneFramework.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.DataAccess.DAL.DAPPER
{
    public class EczaneDal : DapperContext<Eczane>
    {
        public List<Eczane> GetList()
        {
           return ListKomutCalistir("select * from Eczanes").ToList();
        }

        public Eczane GetEczaneById(int Id)
        {
            return KomutCalistir($"select * from Eczanes where Id={Id}");
        }
    }
}
