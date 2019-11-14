using CoreIntroduction.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreIntroduction.DataAccess
{
    public class ShopContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public ShopContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Name = "Монитор",
                    Price = 24000,
                    Amount = 10
                },
                new Item
                {
                    Name = "Телефон",
                    Price = 40000,
                    Amount = 20
                }   
            );
        }
    }
}
