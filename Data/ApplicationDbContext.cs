using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<FoodChain> FoodChains { get; set; }
        public DbSet<Allergy> Allergies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FoodChain>().ToTable("FoodChain");
            modelBuilder.Entity<Allergy>().ToTable("Allergy");

            // Food Chain
            modelBuilder.Entity<FoodChain>()
                .HasMany(a => a.Allergy);
            modelBuilder.Entity<FoodChain>()
                .HasKey(f => f.FoodChainID);

            // Allergy
            modelBuilder.Entity<Allergy>()
                .HasKey(a => a.AllergyID);

            base.OnModelCreating(modelBuilder);
        }
    }
}
