using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DomainLayer.Model
{
    public class OrderView
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public string CustomerId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string DeliveryAddress { get; set; }
    }
}
