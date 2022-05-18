#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using xavier_final.prof;

namespace xavier_final.Data
{
    public class xavier_finalContext : DbContext
    {
        public xavier_finalContext (DbContextOptions<xavier_finalContext> options)
            : base(options)
        {
        }

        public DbSet<xavier_final.prof.Class> Class { get; set; }
    }
}
