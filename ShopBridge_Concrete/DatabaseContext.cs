using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ShopBridge_Model;

namespace ShopBridge_Concrete
{
   public class DatabaseContext :DbContext
    {
        public DatabaseContext() : base("name=SqlDBEntities")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
