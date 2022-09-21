using ECommerceApp.DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.ServiceLayer
{
    public interface Iorderview
    {
        Task<IEnumerable<Customer>> GetCustomers();

        Task<IEnumerable<OrderView>> GetOrders();

        Task<OrderView> GetOrder(int? OrderId);

        Task<int> AddCustomer(Customer cust);

        Task<int> AddOrder(Orders order);

        Task<int> DeleteOrder(int? OrderId);

        Task UpdateOrder(Orders order);
    }
}
