using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WishListController : ControllerBase
    {
        IWishListService _wishlistService;

        public WishListController(IWishListService wishlistService)
        {
            _wishlistService = wishlistService;
        }

        [HttpPost("addwishlist")]
        public IActionResult AddWishList(WishList wishList)
        {
            var result = _wishlistService.AddWishList(wishList);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updatewishlist")]
        public IActionResult UpdateWishList(WishList wishList)
        {
            var result = _wishlistService.UpdateWishList(wishList);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deletewishlist")]
        public IActionResult DeleteWishList(WishList wishList)
        {
            var result = _wishlistService.DeleteWishList(wishList);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallwishlist")]
        public IActionResult GetAllWishList()
        {
            var result = _wishlistService.GetAllWishList();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getwishlistdto")]
        public IActionResult GetWishListDto()
        {
            var result = _wishlistService.GetAllWishListDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getwishlistbyid")]
        public IActionResult GetWishListByID(Guid id)
        {
            var result = _wishlistService.GetWishList(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
    }
}
