using Business.Sevices.Interfaces;
using DataTransfer.Concrete;
using Entities.Consts;
using Microsoft.AspNetCore.Mvc;

namespace KYSProjectApi.Controllers.Product;

[Route("api/[controller]")]
[ApiController]
public class ProductController (IProductService productService) : ControllerBase
{
    
    [HttpGet ("GetAllProduct")]
    public async Task<IActionResult> GetAllProduct()
    {
        // var productList = await productService.GetFilteredListAsync();
        
        var productList = await productService.GetFilteredListAsync
        (
            select: x => new GetAllProductDto()
            {
                ProductCode = x.ProductCode,
                ProductName = x.ProductName,
                ProductPrice = x.ProductPrice,
                Stock = x.Stock
            },
            where: x => x.Status != Status.Passive,
            orderBy: x => x.OrderByDescending(z => z.CreatedDate)
        );

        return Ok(productList);
    }

    [HttpGet("GetProduct")]
    public async Task<IActionResult> GetProduct([FromQuery] Int64 productCode)
    {
        
        var product = await productService.GetByIdAsync<GetAllProductDto>(x=> x.ProductCode == productCode);
    
        if (product == null)
        {
            return NotFound(); // Ürün bulunamazsa 404 döndür
        }

        return Ok(product);
    }
}