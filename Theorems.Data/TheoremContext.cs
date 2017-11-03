using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Theorems.Data
{
    class TheoremContext : DbContext
    {
        public DbSet<Theorem> Theorems { get; set; }
        public DbSet<Author> Authors { get; set; }

        public TheoremContext() : base("TheoremDB")
        {
                
        }
    }
}
