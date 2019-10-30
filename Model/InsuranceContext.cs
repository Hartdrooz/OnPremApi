using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hybrid.Prem.Client.Model
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options) : base(options)
        {

        }

        public DbSet<Insurance> Insurances { get; set; }

        public DbSet<Claim> Claims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Insurance>().ToTable("Insurance");
            modelBuilder.Entity<Claim>().ToTable("Claim");
        }
    }
}
