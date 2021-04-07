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
        public DbSet<User> Users { get; set; }
        public DbSet<UserFunding> UserFundings { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserFunding>().HasKey(uf => new { uf.FundingId, uf.UserId});

            SeedData(modelBuilder);
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
