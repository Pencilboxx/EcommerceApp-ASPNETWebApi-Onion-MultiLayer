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
    public class Categorycontroller : ControllerBase
    {
        private readonly IProductcategory Productcategory;
        private readonly ILogger<Categorycontroller> _logger;
        #region "constructor init"
        public Categorycontroller(IProductcategory productcategory, ILogger<Categorycontroller> logger)
        {
            Productcategory = productcategory;
            _logger = logger;


        }
        #endregion
        [HttpGet]
        [Route("/All Category Details")]
        public ActionResult GetCategory()
        {
            try
            {
                _logger.LogInformation("Get All Category Details endpoint start");
                var category = Productcategory.GetCategory();
                if (category != null && category.Count > 0)
                {
                    return Ok(category);
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
        [Route("/One Category Details")]
        public ActionResult GetCategory(string CategoryId)
        {
            try
            {
                _logger.LogInformation("Get One Category Details endpoint start");
                var cate = Productcategory.GetCategory(CategoryId);
                if (cate!= null)
                {
                    return Ok(cate);
                }
                _logger.LogInformation("Get One Category Details endpoint complete");

            }
            catch (Exception ex)
            {
                _logger.LogError("Exception occured;Exception detail:" + ex.InnerException);
            }
            return BadRequest("Not Found");

        }

        [HttpPost]
        [Route("/Insert Category")]

        public ActionResult Insertcategory(Categories categories)
        {
            try
            {
                _logger.LogInformation("Get Add Category Details endpoint start");
                Productcategory.Insertcategory(categories);
                _logger.LogInformation("Get Add Category Details endpoint complete");
            }

            catch (Exception ex)
            {
                _logger.LogError("Exception occured;Exception detail:" + ex.InnerException);

            }


            return Ok("Category added");
        }






    }
}
