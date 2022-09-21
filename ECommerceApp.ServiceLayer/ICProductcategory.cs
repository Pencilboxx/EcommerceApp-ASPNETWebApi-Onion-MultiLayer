using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApp.DomainLayer.Model;
using ECommerceApp.RepositoryLayer;


namespace ECommerceApp.ServiceLayer
{
    public interface ICProductcategory
    {
        IList<Categories> GetCCategory();
        Categories GetCCategory(string Cname);
    }
}
