using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApp.DomainLayer.Model;
using ECommerceApp.RepositoryLayer;

namespace ECommerceApp.ServiceLayer
{
    public class Productdetails : IProductdetails
    {
        public ApplicationContext ApplicationContext;


        public Productdetails(ApplicationContext applicationContext)
        {
            ApplicationContext = applicationContext;
        }
        public void DeleteProduct(string ProID)
        {
            Products c = GetProducts(ProID);
            if (ProID != null)
            {
                ApplicationContext.Remove<Products>(c);
                ApplicationContext.SaveChanges();
            }
        }

        public IList<Products> GetProducts()
        {
            return ApplicationContext.Set<Products>().ToList();
        }

        public Products GetProducts(string ProID)
        {
            return ApplicationContext.Find<Products>(ProID);
        }

        public void InsertProduct(Products product)
        {
            ApplicationContext.Add<Products>(product);
            ApplicationContext.SaveChanges();
        }

        public void UpdateProduct(Products product)
        {
            ApplicationContext.Update<Products>(product);
            ApplicationContext.SaveChanges();
        }
    }
}
