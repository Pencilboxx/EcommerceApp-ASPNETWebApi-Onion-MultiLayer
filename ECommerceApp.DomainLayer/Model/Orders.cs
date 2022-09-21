using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DomainLayer.Model
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        [ForeignKey("CustomerID")]
        public string CustomerID { get; set; }
        public DateTime? Odate { get; set; }
        public DateTime? Shipdate { get; set; }

    }
}
