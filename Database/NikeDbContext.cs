using Microsoft.EntityFrameworkCore;
using NikeWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NikeWebApp.Database
{
    public class NikeDbContext : DbContext
    {
        public NikeDbContext(DbContextOptions<NikeDbContext> options) : base(options)
        {

        }
        public DbSet<Products> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }
    }
}
