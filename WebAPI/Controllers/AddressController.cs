using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost("addaddress")]
        public IActionResult AddAddress(Address address)
        {
            var result = _addressService.AddAddress(address);
            if (result.Success) { 
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("updateaddress")]
        public IActionResult UpdateAddress(Address address)
        {
            var result = _addressService.UpdateAddress(address);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("deleteaddress")]
        public IActionResult DeleteAddress(Address address)
        {
            var result = _addressService.DeleteAddress(address);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getalladdress")]
        public IActionResult GetAllAddress()
        {
            var result = _addressService.GetAllAddress();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getaddressbyid")]
        public IActionResult GetAddressByID(Guid id)
        {
            var result = _addressService.GetAddress(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
