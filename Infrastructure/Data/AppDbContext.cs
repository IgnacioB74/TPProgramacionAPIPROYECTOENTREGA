using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace AuthApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opts) 
            : base(opts) 
        {
        }

        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            modelBuilder.Entity<User>()
                        .HasKey(u => u.Id);

            modelBuilder.Entity<Event>()
                        .HasKey(e => e.Id);

            modelBuilder.Entity<Product>()
                        .HasKey(p => p.Id); 

            base.OnModelCreating(modelBuilder);
        }
    }
}
