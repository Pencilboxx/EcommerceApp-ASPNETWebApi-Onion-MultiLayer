using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApp.DomainLayer.Model;
using ECommerceApp.RepositoryLayer;

namespace ECommerceApp.ServiceLayer
{
    public class Productcategory : IProductcategory
    {
        public ApplicationContext ApplicationContext;
        public Productcategory(ApplicationContext applicationContext)
        {
            ApplicationContext = applicationContext;

        }
        public IList<Categories> GetCategory()
        {
            return ApplicationContext.Set<Categories>().ToList();
        }

        public Categories GetCategory(string CategoryId)
        {
            return ApplicationContext.Find<Categories>(CategoryId);
        }

        public void Insertcategory(Categories c)
        {
            ApplicationContext.Add<Categories>(c);
            ApplicationContext.SaveChanges();
        }
        public void DeleteCategory(string CategoryID)
        {
            Categories c = GetCategory(CategoryID);
            if (CategoryID != null)
            {
                ApplicationContext.Remove<Categories>(c);
                ApplicationContext.SaveChanges();
            }
        }

        public void UpdateCategory(Categories category)
        {
            ApplicationContext.Update<Categories>(category);
            ApplicationContext.SaveChanges();
        }
    }
}
