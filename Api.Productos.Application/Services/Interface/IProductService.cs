using Api.Productos.Dto.Dto;
using Api.Productos.Models.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.Pruductos.Application.Services.Interface
{
    public interface IProductService
    {
        Task<ResponseModel> CrearProducto(CrearProductoDto producto);
        Task<List<CrearProductoDto>> GetProductos();
        Task<CrearProductoDto> GetProductoById(int id);
    }
}
