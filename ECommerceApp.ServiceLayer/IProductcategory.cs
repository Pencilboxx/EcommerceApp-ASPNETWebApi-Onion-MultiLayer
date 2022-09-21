using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApp.DomainLayer.Model;
using ECommerceApp.RepositoryLayer;

namespace ECommerceApp.ServiceLayer
{
    public interface IProductcategory
        {
          IList<Categories> GetCategory();
          Categories GetCategory(string CategoryId);
          void Insertcategory(Categories c);
     }
  

}
