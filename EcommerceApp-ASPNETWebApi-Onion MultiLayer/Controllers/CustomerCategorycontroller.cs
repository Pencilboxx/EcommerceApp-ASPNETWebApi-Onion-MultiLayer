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
    public class CustomerCategorycontroller : ControllerBase
    {
        private readonly ICProductcategory CProductcategory;
        private readonly ILogger<CustomerCategorycontroller> _logger;
        #region "constructor init"
        public CustomerCategorycontroller(ICProductcategory cproductcategory, ILogger<CustomerCategorycontroller> logger)
        {
            CProductcategory = cproductcategory;
            _logger = logger;


        }
        #endregion
        [HttpGet]
        [Route("/ Category Details")]
        public ActionResult GetCCategory()
        {
            try
            {
                _logger.LogInformation("Get All Category Details endpoint start");
                var categ = CProductcategory.GetCCategory();
                if (categ != null && categ.Count > 0)
                {
                    return Ok(categ);
                }
                _logger.LogInformation("Get All Category Details endpoint complete");


            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occured;Exception detail:" + ex.InnerException);
            }
            return BadRequest("Not Found");

        }

        [HttpGet]
        [Route("/One Category ")]
        public ActionResult GetCCategory(string Cname)
        {
            try
            {
                _logger.LogInformation("Get One Category Details endpoint start");
                var ca = CProductcategory.GetCCategory(Cname);
                if (ca != null)
                {
                    return Ok(ca);
                }
                _logger.LogInformation("Get One Category Details endpoint complete");

            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occured;Exception detail:" + ex.InnerException);
            }
            return BadRequest("Not Found");

        }
    }
    }
