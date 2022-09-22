using ECommerceApp.DomainLayer.Model;
using ECommerceApp.ServiceLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceApp_ASPNETWebApi_Onion_MultiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class Orderviewcontroller:ControllerBase

    {
        Iorderview orderviews;
        public Orderviewcontroller(Iorderview _orderviews)
        {
            orderviews = _orderviews;
        }

        [HttpGet]
        [Route("/GetOrders")]
        public async Task<IActionResult> GetOrders()
        {
            try
            {
                var orders = await orderviews.GetOrders();
                if (orders == null)
                {
                    return NotFound();
                }

                return Ok(orders);
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        [Route("/GetCustomers")]
        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                var custs = await orderviews.GetCustomers();
                if (custs == null)
                {
                    return NotFound();
                }

                return Ok(custs);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("/GetOrder")]
        public async Task<IActionResult> GetOrder(int? orderId)
        {
            if (orderId == null)
            {
                return BadRequest();
            }

            try
            {
                var order = await orderviews.GetOrder(orderId);

                if (order == null)
                {
                    return NotFound();
                }

                return Ok(order);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("/AddCustomer")]
        public async Task<IActionResult> AddCustomer([FromBody] Customer model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var custId = await orderviews.AddCustomer(model);
                    if (custId > 0)
                    {
                        return Ok(custId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }

        [HttpPost]
        [Route("/AddOrder")]
        public async Task<IActionResult> AddOrder([FromBody] Orders model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var orderId = await orderviews.AddOrder(model);
                    if (orderId > 0)
                    {
                        return Ok(orderId);
                    }
                    else
                    {
                        return NotFound();
                    }
                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }

        [HttpPost]
        [Route("/DeleteOrder")]
        public async Task<IActionResult> DeleteOrder(int? orderId)
        {
            int result = 0;

            if (orderId == null)
            {
                return BadRequest();
            }

            try
            {
                result = await orderviews.DeleteOrder(orderId);
                if (result == 0)
                {
                    return NotFound();
                }
                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


        [HttpPost]
        [Route("/UpdateOrder")]
        public async Task<IActionResult> UpdateOrder([FromBody] Orders model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await orderviews.UpdateOrder(model);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }


    }
}
