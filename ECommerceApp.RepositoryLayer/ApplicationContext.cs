using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApp.DomainLayer.Model;

namespace ECommerceApp.RepositoryLayer
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {


        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Orderdetails> Orderdetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}
