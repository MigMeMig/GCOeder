using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using vonOeder.Models;

namespace vonOeder.Data
{
    public class vonOederContext : DbContext
    {
        public vonOederContext (DbContextOptions<vonOederContext> options)
            : base(options)
        {
        }

        public DbSet<vonOeder.Models.User> User { get; set; }
    }
}
