using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp.DomainLayer.Model
{
    public  class Categories
    {
        [Key]
        public string CategoryId { get; set; }
        
        public string Cname { get; set; }
        public string CDescription { get; set; }


    }
}
