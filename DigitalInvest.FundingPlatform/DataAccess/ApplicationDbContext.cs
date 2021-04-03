using DigitalInvest.FundingPlatform.Data;
using DigitalInvest.FundingPlatform.DataAccess.Entitities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace DigitalInvest.FundingPlatform.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Funding> Fundings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            SeedData(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var server = "localhost";
            var port = "5432";
            var name = "postgres";
            var user = "postgres";
            var password = "postgres";

            optionsBuilder.UseNpgsql($"Host={server};Port={port};Database={name};Username={user};Password={password}");
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            var fundings = new List<Funding>();
            var random = new Random();
            var currentDate = DateTime.UtcNow;

            for (var i = 1; i < 15; i++)
            {
                fundings.Add(new Funding
                {
                    Id = Guid.NewGuid(),
                    Name = $"Property {i}",
                    Target = random.Next(500000, 1000000),
                    Investment = 0,
                    CreatedOn = currentDate,
                    ExpirationDate = currentDate.AddDays(random.Next(20, 40))
                });
            }

            modelBuilder.Entity<Funding>().HasData(fundings);
        }
    }
}
