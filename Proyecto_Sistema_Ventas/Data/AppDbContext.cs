using Microsoft.EntityFrameworkCore;
using Proyecto_Sistema_Ventas.Models;

namespace Proyecto_Sistema_Ventas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Detalle_Pedido> Detalle_Pedidos { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }
        public DbSet<Factura> Facturas { get; set; }
    }
}