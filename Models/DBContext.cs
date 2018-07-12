using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars2._0.Models
{
    class DBContext: DbContext
    {
        public DBContext() : base(Properties.Settings.Default.DBConnection) { }


        // Read about MongoDB for Single Entity DB
        public DbSet<CarEntity> Cars { get; set; }
    }
}
