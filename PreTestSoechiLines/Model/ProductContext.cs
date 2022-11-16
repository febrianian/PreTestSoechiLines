using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreTestSoechiLines.Model
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base(@"Data Source=IT-FEBRIAN\SQLEXPRESS;Initial Catalog=DataProduct; User Id=sa; Password=system")
        {

        }
        public DbSet<UOM> UOM { get; set; }
    }
}
