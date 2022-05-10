using Api.Pruductos.Application.Services.Interface;
using Api.Productos.Data.Context;
using Api.Productos.Domain.Entities;
using Api.Productos.Dto.Dto;
using Api.Productos.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Api.Productos.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly LogisticaContext _context;
        private readonly ILogger<ProductService> _logger;

        public ProductService(LogisticaContext context, ILogger<ProductService> logger)
        {
            _context = context;
            _logger = logger;


        }

        public async Task<ResponseModel> CrearProducto(CrearProductoDto producto)
        {
            try
            {
                Producto nuevoProducto = new Producto()
                {
                    Descripcion = producto.Descripcion,
                    Nombre = producto.Nombre,
                    Valor = Convert.ToInt32(producto.Precio)
                };


                _context.Producto.Add(nuevoProducto);
                await _context.SaveChangesAsync();

                ResponseModel response = new ResponseModel()
                {
                    Descripcion = "Producto Creado",
                    Exitoso = true
                };
                return response;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"error {ex.Message}");
                throw;
            }
        }

        public async Task<List<CrearProductoDto>> GetProductos()
        {
            try
            {
                List<CrearProductoDto> productosResponse = new List<CrearProductoDto>();
                var productos = await _context.Producto.ToListAsync();

                foreach (var prod in productos)
                {
                    CrearProductoDto currProd = new CrearProductoDto()
                    {
                        Cantidad = prod.Cantidad,
                        Nombre = prod.Nombre,
                        Descripcion = prod.Descripcion,
                        Id = prod.Id,
                        Precio = prod.Valor,
                        Img = prod.Image

                    };

                    productosResponse.Add(currProd);

                }

                return productosResponse;

            }
            catch (Exception ex)
            {

                _logger.LogInformation($"error {ex.Message}");
                throw;
            }
        }

        public async Task<CrearProductoDto> GetProductoById(int id)
        {
            try
            {
                var prod = await _context.Producto.FindAsync(id);
                CrearProductoDto productoResponse = new CrearProductoDto()
                {
                    Cantidad = prod.Cantidad,
                    Nombre = prod.Nombre,
                    Descripcion = prod.Descripcion,
                    Id = prod.Id,
                    Precio = prod.Valor,
                    Img = prod.Image
                };

                return productoResponse;
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"error {ex.Message}");
                throw;
            }
        }
    }
}
