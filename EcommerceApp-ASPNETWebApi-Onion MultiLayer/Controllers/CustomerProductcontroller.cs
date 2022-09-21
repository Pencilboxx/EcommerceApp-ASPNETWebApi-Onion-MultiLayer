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
    public class CustomerProductcontroller:ControllerBase
    {
        private readonly IProductdetails Productdetails;
        private readonly ILogger<CustomerProductcontroller> _logger;
        #region "constructor init"
        public CustomerProductcontroller(IProductdetails productdetails, ILogger<CustomerProductcontroller> logger)
        {
            Productdetails = productdetails;
            _logger = logger;


        }
        #endregion
        [HttpGet]
        [Route("/ Product Details")]
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
        [Route("/One Product ")]
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

    }
}
