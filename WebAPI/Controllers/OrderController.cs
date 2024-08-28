using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("addorder")]
        public IActionResult AddOrder(Order order)
        {
            var result = _orderService.AddOrder(order);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateorder")]
        public IActionResult UpdateOrder(Order order)
        {
            var result = _orderService.UpdateOrder(order);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteorder")]
        public IActionResult DeleteOrder(Order order)
        {
            var result = _orderService.DeleteOrder(order);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallorder")]
        public IActionResult GetAllOrder()
        {

            var result = _orderService.GetAllOrder();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getorderbyid")]
        public IActionResult GetOrderByID(Guid id)
        {

            var result = _orderService.GetOrder(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
