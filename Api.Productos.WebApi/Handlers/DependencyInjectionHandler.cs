using Api.Productos.Application.Services;
using Api.Pruductos.Application.Services.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace Api.Productos.WebApi.Handlers
{
    public static class DependencyInjectionHandler
    {
        public static void DependencyInjectionConfig(IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }

    }
}
