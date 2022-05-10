using Api.Productos.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Productos.Data.Context
{
    public class LogisticaContext : DbContext
    {
        public LogisticaContext(DbContextOptions<LogisticaContext> options) : base(options)
        {
        }
        public DbSet<Producto> Producto { get; set; }
    }
}
