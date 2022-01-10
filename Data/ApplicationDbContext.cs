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
        public DbSet<AllergyGroup> AllergyGroups { get; set; }
        public DbSet<UserAllergySelection> UserAllergySelections { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Food Chains
            modelBuilder.Entity<FoodChain>()
                .ToTable("FoodChain")
                .HasKey(f => f.FoodChainID);

            modelBuilder.Entity<UserAllergySelection>()
                .ToTable("UserAllergySelection")
                .HasKey(u => u.ID);

            // Allergies Table
            modelBuilder.Entity<Allergy>()
                .ToTable("Allergy")
                .HasKey(a => a.AllergyID);

            // Allergy Group Table
            modelBuilder.Entity<AllergyGroup>()
                .ToTable("AllergyGroup")
                .HasKey(g => g.GroupID);

            modelBuilder.Entity<AllergyGroup>()
                .HasMany(a => a.Allergies)
                .WithOne(g => g.AllergyGroup)
                .HasForeignKey(a => a.GroupID)
                .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(modelBuilder);
        }
    }
}
