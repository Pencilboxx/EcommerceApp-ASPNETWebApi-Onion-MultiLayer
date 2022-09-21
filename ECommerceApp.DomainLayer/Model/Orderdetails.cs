using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DomainLayer.Model
{
    public class Orderdetails
    {
        [Key]
        public string OId { get; set; }
        [Key]
        public string ProId { get; set; }

        [Required]
        public int quantity { get; set; }
        public int Unitcost { get; set; }


    }
}
