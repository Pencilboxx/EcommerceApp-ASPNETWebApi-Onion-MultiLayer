using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECommerceApp.ServiceLayer;
using ECommerceApp.DomainLayer.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace EcommerceApp_ASPNETWebApi_Onion_MultiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Productcontroller:ControllerBase
    {
        private readonly IProductdetails Productdetails;
        private readonly ILogger<Productcontroller> _logger;
        #region "constructor init"
        public Productcontroller(IProductdetails productdetails, ILogger<Productcontroller> logger)
        {
            Productdetails = productdetails;
            _logger = logger;


        }
        #endregion

        [HttpGet]
        [Route("/All Product Details")]
        public ActionResult GetProducts()
        {
            try
            {
                _logger.LogInformation("Get All Product Details endpoint start");
                var p = Productdetails.GetProducts();
                if (p != null && p.Count > 0)
                {
                    return Ok(p);
                }
                _logger.LogInformation("Get All Product Details endpoint complete");


            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occured;Exception detail:" + ex.InnerException);
            }
            return BadRequest("Not Found");

        }

        [HttpGet]
        [Route("/One product details")]
        public ActionResult GetProducts(string ProID)
        {
            try
            {
                _logger.LogInformation("Get One Product Details endpoint start");
                var pr = Productdetails.GetProducts(ProID);
                if (pr != null)
                {
                    return Ok(pr);
                }
                _logger.LogInformation("Get One Product Details endpoint complete");
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occured;Exception detail:" + ex.InnerException);
            }



            return BadRequest("Not Found");
        }

        [HttpPost]
        [Route("/Insert Product Details")]

        public ActionResult AddProduct(Products product)
        {
            try
            {
                _logger.LogInformation("Add Product Details endpoint start");
                Productdetails.InsertProduct(product);
                _logger.LogInformation("Add Product Details endpoint complete");
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occured;Exception detail:" + ex.InnerException);
            }


            return Ok("Product added");
        }

        [HttpPut]
        [Route("/Update Product Details")]

        public ActionResult UpdateProduct(Products product)
        {
            try
            {
                _logger.LogInformation("Update Product Details endpoint start");

                Productdetails.UpdateProduct(product);

                _logger.LogInformation("Update Product Details endpoint complete");
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occured;Exception detail:" + ex.InnerException);
            }

            return Ok("Updated");
        }


        [HttpDelete]
        [Route("/Delete Product Details")]

        public ActionResult DeleteProduct(string ProID)
        {
            try
            {
                _logger.LogInformation("Delete Product Details endpoint start");
                Productdetails.DeleteProduct(ProID);
                _logger.LogInformation("Delete Product Details endpoint complete");
            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occured;Exception detail:" + ex.InnerException);
            }


            return Ok("Product Removed");
        }
    }
}
