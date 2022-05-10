using Api.Productos.Dto.Dto;
using Api.Pruductos.Application.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Productos.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductosController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost("CrearProducto")]
        public async Task<IActionResult> CrearProducto(CrearProductoDto producto)
        {
            var response = await _productService.CrearProducto(producto);
            return Ok(response);
        }

        [HttpGet("GetProductos")]
        public async Task<IActionResult> GetProductos()
        {
            var response = await _productService.GetProductos();
            return Ok(response);
        }

        [HttpGet("GetProductoById")]
        public async Task<IActionResult> GetProductoById(int id)
        {
            var response = await _productService.GetProductoById(id);
            return Ok(response);
        }
    }
}
