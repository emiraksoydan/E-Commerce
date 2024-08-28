using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost("addcategory")]
        public IActionResult Add(Category categories)
        {
            var result = _categoryService.AddCategory(categories);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("updatecategory")]
        public IActionResult Update(Category categories)
        {
            var result = _categoryService.UpdateCategory(categories);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletecategory")]
        public IActionResult Delete(Category categories)
        {
            var result = _categoryService.DeleteCategory(categories);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getallcategory")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAllCategory();

            if (result.Success)
            {
                return Ok(result); 
            }
            return BadRequest(result);
        }
        [HttpGet("getcategorybyid")]
        public IActionResult GetCategoryById(Guid id)
        {
            var result = _categoryService.GetCategory(id);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
