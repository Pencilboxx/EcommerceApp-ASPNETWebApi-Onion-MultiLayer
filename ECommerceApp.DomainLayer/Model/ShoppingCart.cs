using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DomainLayer.Model
{
    public class ShoppingCart
    {
        [Required]
        public string RecordId { get; set; }
        public string CartId { get; set; }
        public int quantity { get; set; }
        [Key]
        public string ProId { get; set; }
        public string DateCreated { get; set; }

    }
}
