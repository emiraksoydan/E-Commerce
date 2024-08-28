using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        IStockService _stockService;

        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet("getallstocks")]
        public IActionResult GetAllStock() { 
            var getallstock = _stockService.GetAllStock();
            if (getallstock.Success) {
                return Ok(getallstock);
            }
            return BadRequest(getallstock);
        }


        [HttpGet("getallstockbyid")]
        public IActionResult GetAllStock(Guid id)
        {
            var getallstock = _stockService.GetStock(id);
            if (getallstock.Success)
            {
                return Ok(getallstock);
            }
            return BadRequest(getallstock);
        }
        [HttpPost("addstock")]
        public IActionResult AddStock( Stock stock)
        {
            var getallstock = _stockService.AddStock(stock);
            if (getallstock.Success)
            {
                return Ok(getallstock);
            }
            return BadRequest(getallstock);
        }
        [HttpPost("updatestock")]
        public IActionResult UpdateStock(Stock stock)
        {
            var getallstock = _stockService.UpdateStock(stock);
            if (getallstock.Success)
            {
                return Ok(getallstock);
            }
            return BadRequest(getallstock);
        }
        [HttpPost("deletestock")]
        public IActionResult DeleteStock(Stock stock)
        {
            var getallstock = _stockService.DeleteStock(stock);
            if (getallstock.Success)
            {
                return Ok(getallstock);
            }
            return BadRequest(getallstock);
        }
    }
}
