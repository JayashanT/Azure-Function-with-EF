using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class SampleDbContext:DbContext
    {
        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {

        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
