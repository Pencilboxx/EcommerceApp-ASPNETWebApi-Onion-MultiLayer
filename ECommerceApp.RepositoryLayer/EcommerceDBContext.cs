using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ECommerceApp.DomainLayer.Model;

namespace ECommerceApp.RepositoryLayer
{
    public class EcommerceDBContext : DbContext
    {
        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options) : base(options) { }


        DbSet<Customer> Customers { get; set; }
        DbSet<Products> Products { get; set; }
        DbSet<Orders> customerOrders { get; set; }

        DbSet<Categories> categories { get; set; }

        DbSet<Orderdetails> orderdetails{ get; set; }

    }
}
