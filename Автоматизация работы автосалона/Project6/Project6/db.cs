﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Project6
{
    class db : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
    }
}
