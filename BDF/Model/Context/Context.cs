using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDF.Model
{
    public class Context : DbContext
    {
        public DbSet<Bill> bills { get; set; }
        public DbSet<Item> items { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderInBill> orders_in_bills { get; set; }
        public DbSet<Table> tables { get; set; }

        public Context()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Username=postgres;Password=p;Database=BDF3");
        }
    }
}
