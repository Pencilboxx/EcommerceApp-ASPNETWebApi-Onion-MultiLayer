using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerceApp.DomainLayer.Model;
using ECommerceApp.RepositoryLayer;

namespace ECommerceApp.ServiceLayer
{
    public interface IProductdetails
    {
        IList<Products> GetProducts();
        Products GetProducts(string ProID);
        void InsertProduct(Products product);

        void DeleteProduct(string ProID);
        void UpdateProduct(Products product);


    }
}
