using EcommerceAPI.Context;
using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            var orders = _context.Orders.ToList();
            if (orders is null)
            {
                return NotFound("Orders not found!");
            }

            return orders;
        }

        [HttpGet("id:int")]
        public ActionResult<Order> Get(int id)
        {
            var order = _context.Orders.FirstOrDefault(x => x.OrderId == id);
            if(order is null)
            {
                return NotFound("Order not found!");
            }

            return order;
        }
    }
}