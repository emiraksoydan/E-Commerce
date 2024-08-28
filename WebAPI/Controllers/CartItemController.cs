using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        ICartItemsService _cartItem;
        public CartItemController(ICartItemsService cartItem)
        {
            _cartItem = cartItem;
        }
        [HttpPost("addcartitem")]
        public IActionResult AddCartItem(CartItem cartItem) { 
           var result =  _cartItem.AddCartItem(cartItem);
            if (result.Success) {
            
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletecartitem")]
        public IActionResult DeleteCartItem(CartItem cartItem)
        {
            var result = _cartItem.DeleteCartItem(cartItem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updatecartitem")]
        public IActionResult UpdateCartItem(CartItem cartItem)
        {
            var result = _cartItem.UpdateCartItem(cartItem);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallcartitem")]
        public IActionResult GetAllCartItem()
        {
            var result = _cartItem.GetAllCartItem();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcartitembyid")]
        public IActionResult GetCartItemByID(Guid id)
        {
            var result = _cartItem.GetCartItem(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
