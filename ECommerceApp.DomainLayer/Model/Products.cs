using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DomainLayer.Model
{
    public class Products
    {
        [Key]
        public string ProID { get; set; }
         [Key]
         public string CategoryId { get; set; }
        [Required]
        public string Mnum { get; set; }
        public string Mname { get; set; }
        public int Ucost { get; set; }
        public string Description { get; set; }
    }
}
