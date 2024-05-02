    using CafeApiProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeApiProj
{
    public class AppDbContext : DbContext
    {
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual  DbSet<OrderProduct> OrderProducts { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Order> Orders { get; set; } 
        public virtual DbSet<Customer> Customers { get; set; }  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CafeDb;Trusted_Connection=True;");
            
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(products => products.Category)
                .WithMany(productcategory => productcategory.Products)
                .HasForeignKey(products => products.CategoryId);

            modelBuilder.Entity<Order>()
                .HasOne(orders => orders.Employee)
                .WithMany(employees => employees.Orders)
                .HasForeignKey(orders => orders.EmployeeId);

            modelBuilder.Entity<Order>()
                .HasOne(orders => orders.Customer)
                .WithMany(customers => customers.Orders)
                .HasForeignKey(orders => orders.CustomerId);

            modelBuilder.Entity<OrderProduct>() //cоставной 
                .HasKey(orderproducts => new { orderproducts.OrderId, orderproducts.ProductId });

            modelBuilder.Entity<OrderProduct>()
                .HasOne(orderproducts => orderproducts.Order)
                .WithMany(orders => orders.OrderProducts)
                .HasForeignKey(orderproducts => orderproducts.OrderId);
        }
    }
}