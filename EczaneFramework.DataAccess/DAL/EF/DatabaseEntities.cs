using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EczaneFramework.Entities.Tables;

namespace EczaneFramework.DataAccess.DAL.EF
{
    public class DatabaseEntities : DbContext
    {
        public DatabaseEntities()
        {

        }

        public virtual DbSet<Eczane> Eczane { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }        
        //
        public virtual DbSet<Rol> Rol { get; set; }

    }
}
