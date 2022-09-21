using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DomainLayer.Model
{
    public class Orderdetails
    {
        [Key]
        public string OId { get; set; }
        [ForeignKey("ProId")]
        public string ProId { get; set; }

        [Required]
        public int quantity { get; set; }
        public int Unitcost { get; set; }


    }
}
