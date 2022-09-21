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
        public int CustomerId { get; set; }

        [Required]
        public string FullName { get; set; }

        public string EmailAddress { get; set; }
        public string Password{ get; set; }
        public string DeliveryAdd { get; set; }


    }
}
