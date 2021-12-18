using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DBSyncFusion.Models;

namespace DBSyncFusion.Data
{
    public class DBSyncFusionContext : DbContext
    {
        public DBSyncFusionContext (DbContextOptions<DBSyncFusionContext> options)
            : base(options)
        {
        }

        public DbSet<DBSyncFusion.Models.Person> Person { get; set; }
    }
}
