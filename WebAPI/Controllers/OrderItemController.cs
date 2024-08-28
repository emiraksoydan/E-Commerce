using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        IOrderItemService _orderItemService;
        public OrderItemController(IOrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }
        [HttpPost("addorderitem")]
        public IActionResult OrderItemAdd(OrderItem orderItem)
        {
            var result = _orderItemService.AddOrderItem(orderItem);
            if (result.Success) { 
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateorderitem")]
        public IActionResult OrderItemUpdate(OrderItem orderItem)
        {
            var result = _orderItemService.UpdateOrderItem(orderItem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteorderitem")]
        public IActionResult OrderItemDelete(OrderItem orderItem)
        {
            var result = _orderItemService.DeleteOrderItem(orderItem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallorderitem")]
        public IActionResult GetAllOrderItem()
        {
            var result = _orderItemService.GetAllOrderItem();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getorderitembyid")]
        public IActionResult GetOrderItemByID(Guid id)
        {
            var result = _orderItemService.GetOrderItem(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
