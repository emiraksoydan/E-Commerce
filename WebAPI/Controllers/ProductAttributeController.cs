using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAttributeController : ControllerBase
    {
        IProductAttribute _productAttribute;

        public ProductAttributeController(IProductAttribute productAttribute)
        {
            _productAttribute = productAttribute;
        }
        [HttpPost("addproductattribute")]
        public IActionResult AddProductAttribute(ProductAttributes productAttribute) {
            var result = _productAttribute.AddProductAttribute(productAttribute);
            if (result.Success) { 
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updateproductattribute")]
        public IActionResult UpdateProductAttribute(ProductAttributes productAttribute)
        {
            var result = _productAttribute.UpdateProductAttribute(productAttribute);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteproductattribute")]
        public IActionResult DeleteProductAttribute(ProductAttributes productAttribute)
        {
            var result = _productAttribute.DeleteProductAttribute(productAttribute);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallproductattribute")]
        public IActionResult GetAllProductAttribute()
        {
            var result = _productAttribute.GetAllProductAttribute();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("getproductattributebyid")]
        public IActionResult GetProductAttributeByID(Guid id)
        {
            var result = _productAttribute.GetProductAttribute(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
