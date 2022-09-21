using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DomainLayer.Model
{
    public class Customer
    {
        [Key]
        public string CustomerId { get; set; }

        [Required]
        public string FullName { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        [Required]
        public string Password{ get; set; }
        [Required]
        public string DeliveryAdd { get; set; }


    }
}
