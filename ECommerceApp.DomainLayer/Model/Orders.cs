using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DomainLayer.Model
{
    public class Orders
    {
        [Key]
        public string OId { get; set; }
        [Key]
        public int CustomerID { get; set; }
        public DateTime? Odate { get; set; }
        public DateTime? Shipdate { get; set; }

    }
}
