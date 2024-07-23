using Fall2024OrderSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fall2024OrderSystem.Data;

public class StoreContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } 
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HPCTech2024FallStore;Trusted_Connection=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        Customer customer = new Customer()
        {
            Id = 1,
            FirstName = "Eric",
            LastName = "Couch",
            Addess = "201 Shaffner St.",
            //Email = "eric.couch@cognizant.com",
            Phone = "(817) 304-9048"
        };

        modelBuilder.Entity<Customer>().HasData(customer);

        modelBuilder.Entity<Product>().HasData(new Product()
        {
            Id = 1,
            Name = "Meat Lover's Pizza",
            Price = 9.99M
        });
        modelBuilder.Entity<Product>().HasData(new Product()
        {
            Id = 2,
            Name = "Deluxe Pizza",
            Price = 12.99M
        });

    }
}
