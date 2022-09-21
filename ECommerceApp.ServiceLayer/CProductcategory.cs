using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApp.DomainLayer.Model;
using ECommerceApp.RepositoryLayer;

namespace ECommerceApp.ServiceLayer
{
   public class CProductcategory:ICProductcategory
    {
        public ApplicationContext ApplicationContext;
        public CProductcategory(ApplicationContext applicationContext)
        {
            ApplicationContext = applicationContext;

        }
        public IList<Categories> GetCCategory()
        {
            return ApplicationContext.Set<Categories>().ToList();
        }

        public Categories GetCCategory(string CategoryId)
        {
            return ApplicationContext.Find<Categories>(CategoryId);
        }

    }

}
