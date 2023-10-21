using API_IBGE_BALTA.Data.Mappings;
using API_IBGE_BALTA.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace API_IBGE_BALTA.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LocationMapping());
        }

    }
}
