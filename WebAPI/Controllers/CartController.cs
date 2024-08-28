using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }
        [HttpPost("addcart")]
        public IActionResult AddCart(Cart cart)
        {
            var result = _cartService.AddCart(cart);
            if (result.Success) { 
            
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updatecart")]
        public IActionResult UpdateCart(Cart cart)
        {
            var result = _cartService.UpdateCart(cart);
            if (result.Success)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletecart")]
        public IActionResult DeleteCart(Cart cart)
        {
            var result = _cartService.DeleteCart(cart);
            if (result.Success)
            {

                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getcartbyid")]
        public IActionResult GetCartByID(Guid id)
        {
            var result = _cartService.GetCart(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
