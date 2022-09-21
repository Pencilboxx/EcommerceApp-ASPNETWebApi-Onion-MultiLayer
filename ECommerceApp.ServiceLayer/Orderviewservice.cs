using ECommerceApp.DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApp.RepositoryLayer;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApp.ServiceLayer
{
    public class Orderviewservice : Iorderview
    {
        ApplicationContext db;
        public Orderviewservice(ApplicationContext _db)
        {
            db = _db;
        }

        public async Task<IEnumerable<OrderView>> GetOrders()
        {
            if (db != null)
            {
                return await (from o in db.Orders
                              from c in db.Customers
                              where o.CustomerID == c.CustomerId
                              select new OrderView
                              {
                                  OrderId = o.OrderId,
                                  OrderDate = o.Odate,
                                  ShipDate = o.Shipdate,
                                  CustomerId = o.CustomerID,
                                  FullName = c.FullName,
                                  Email = c.EmailAddress,
                                  DeliveryAddress = c.DeliveryAdd
                              }).ToListAsync();
            }

            return null;
        }
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            if (db != null)
            {
                return await db.Customers.ToListAsync();
            }

            return null;
        }
        public async Task<OrderView> GetOrder(int? OrderId)
        {
            if (db != null)
            {
                return await (from o in db.Orders
                              from c in db.Customers
                              where o.OrderId == OrderId
                              select new OrderView
                              {
                                  OrderId = o.OrderId,
                                  OrderDate = o.Odate,
                                  ShipDate = o.Shipdate,
                                  CustomerId = o.CustomerID,
                                  FullName = c.FullName,
                                  Email = c.EmailAddress,
                                  DeliveryAddress = c.DeliveryAdd
                              }).FirstOrDefaultAsync();
            }

            return null;
        }
        public async Task<string> AddCustomer(Customer cust)
        {
            if (db != null)
            {
                await db.Customers.AddAsync(cust);
                await db.SaveChangesAsync();

                return cust.CustomerId;
            }

            return null;
        }
        public async Task<int> AddOrder(Orders order)
        {
            if (db != null)
            {
                await db.Orders.AddAsync(order);
                await db.SaveChangesAsync();

                return order.OrderId;
            }

            return 0;
        }

        public async Task<int> DeleteOrder(int? OrderId)
        {
            int result = 0;

            if (db != null)
            {
                //Find the post for specific post id
                var order = await db.Orders.FirstOrDefaultAsync(x => x.OrderId == OrderId);

                if (order != null)
                {
                    //Delete that post
                    db.Orders.Remove(order);

                    //Commit the transaction
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }


        public async Task UpdateOrder(Orders order)
        {
            if (db != null)
            {
                //Delete that post
                db.Orders.Update(order);

                //Commit the transaction
                await db.SaveChangesAsync();
            }
        }

        Task<int> Iorderview.AddCustomer(Customer cust)
        {
            throw new NotImplementedException();
        }
    }
}
