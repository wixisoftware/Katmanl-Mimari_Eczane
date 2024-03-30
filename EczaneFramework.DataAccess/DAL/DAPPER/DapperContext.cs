using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EczaneFramework.DataAccess.DAL.DAPPER
{
    public class DapperContext<T>
    {
        //Server=A103LABOGRT;Database=Market;Trusted_Connection=True;
        private string ConnectionString = "Server=DESKTOP-CURF1SS;Database=EczaneTakip;Trusted_Connection=True;";


        protected IEnumerable<T> ListKomutCalistir(string sqlcommand)
        {
            using (var con = new  SqlConnection(ConnectionString))
            {
                var result = con.Query<T>(sqlcommand);
                return result;
            }
        }

        protected T KomutCalistir(string sqlcommand)
        {
            using (var con = new SqlConnection(ConnectionString))
            {
                var result = con.QuerySingle<T>(sqlcommand);
                return result;
            }
        }
    }
}
