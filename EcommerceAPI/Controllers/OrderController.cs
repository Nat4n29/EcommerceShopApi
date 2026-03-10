using EcommerceAPI.Context;
using EcommerceAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

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
        public ActionResult<IEnumerable<Order>> Get(int year)
        {
            var orders = _context.Orders.AsNoTracking().Where(x => x.Date.Year == year).ToList();
            if (orders is null)
            {
                return NotFound("Orders not found!");
            }

            return orders;
        }

        [HttpGet("{id:int}", Name = "FindOrder")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = _context.Orders.AsNoTracking().FirstOrDefault(x => x.OrderId == id);
            if (order is null)
            {
                return NotFound("Order not found!");
            }

            return order;
        }

        [HttpGet("{month}/{year}", Name = "Find Order by Month and Year")]
        public ActionResult<Order> GetOrderByMonthYear(int month, int year)
        {
            var order = _context.Orders.AsNoTracking()
                .FirstOrDefault(o => o.OrderMonthResume.Month == month && o.OrderMonthResume.Year == year);

            if (order is null)
                return NotFound("Order not found!");

            return order;
        }

        //----------------------------------------------------------------------

        [HttpPost]
        public ActionResult Post(Order order)
        {
            if (order is null)
                return BadRequest();

            _context.Orders.Add(order);
            _context.SaveChanges();

            return new CreatedAtRouteResult("FindOrder", new {id = order.OrderId}, order);
        }

        //----------------------------------------------------------------------

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Order order)
        {
            if(id != order.OrderId)
            {
                return BadRequest("The Id intered is different from the Order Id!");
            }

            _context.Entry(order).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok($"The order of ID:{id} was successfully modified!" + order);
        }

        //----------------------------------------------------------------------

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var order = _context.Orders.FirstOrDefault(x => x.OrderId == id);

            if(order is null)
            {
                return NotFound("Order not found!");
            }

            _context.Orders.Remove(order);
            _context.SaveChanges();

            return Ok("The order has been deleted: " + order);
        }
    }
}