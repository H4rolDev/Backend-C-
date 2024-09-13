using Data.DataBase.Seeds;
using Data.DataBase.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase
{

    public class MiDbContext : DbContext
    {

        public MiDbContext(DbContextOptions<MiDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            // Proveedor -> DetalleCompra | uno a muchos
            modelBuilder.Entity<Proveedor>()
                .HasOne<DetalleCompra>()
                .WithOne()
                .HasForeignKey<DetalleCompra>(u => u.proveedor_id)
                .IsRequired();

            // TipoDocumento -> Documento | uno a muchos
            modelBuilder.Entity<TipoDocumento>()
                .HasOne<Documento>()
                .WithOne()
                .HasForeignKey<Documento>(p => p.tipoDocumento_id)
                .IsRequired();

            // Categoria -> Producto | uno a muchos
            modelBuilder.Entity<Categoria>()
                .HasMany<Producto>()
                .WithOne()
                .HasForeignKey(u => u.categoria_id)
                .IsRequired();

            // Estado -> Delivery | uno a uno
            modelBuilder.Entity<Estado>()
                .HasOne<Delivery>()
                .WithOne()
                .HasForeignKey<Delivery>(u => u.estado_id)
                .IsRequired();

            // Estado -> RecojoAlmacen | uno a uno
            modelBuilder.Entity<Estado>()
                .HasOne<RecojoAlmacen>()
                .WithOne()
                .HasForeignKey<RecojoAlmacen>(u => u.estado_id)
                .IsRequired();

            // TipoEntrega -> Delivery | uno a uno
            modelBuilder.Entity<TipoEntrega>()
                .HasOne<Delivery>()
                .WithOne()
                .HasForeignKey<Delivery>(u => u.tipoEntrega_id)
                .IsRequired();

            // TipoEntrega -> RecojoAlmacen | uno a uno
            modelBuilder.Entity<TipoEntrega>()
                .HasOne<RecojoAlmacen>()
                .WithOne()
                .HasForeignKey<RecojoAlmacen>(u => u.tipoEntrega_id)
                .IsRequired();

            // DetalleVenta -> Devolucion | uno a uno
            modelBuilder.Entity<DetalleVenta>()
                .HasOne<Devolucion>()
                .WithOne()
                .HasForeignKey<Devolucion>(u => u.detalleVenta_id)
                .IsRequired();

            // Venta -> DetalleVenta | uno a muchos
            modelBuilder.Entity<Venta>()
                .HasMany<DetalleVenta>()
                .WithOne()
                .HasForeignKey(u => u.venta_id)
                .IsRequired();

            // Cliente -> RecojoAlmacen | uno a muchos
            modelBuilder.Entity<Cliente>()
                .HasMany<RecojoAlmacen>()
                .WithOne()
                .HasForeignKey(u => u.cliente_id)
                .IsRequired();

            // Venta -> TipoEntrega | 
            
            // Cliente -> Venta | uno a muchos
            modelBuilder.Entity<Cliente>()
                .HasMany<Venta>()
                .WithOne()
                .HasForeignKey(u => u.cliente_id)
                .IsRequired();

            // Vendedor -> Venta | uno a muchos
            modelBuilder.Entity<Vendedor>()
                .HasMany<Venta>()
                .WithOne()
                .HasForeignKey(u => u.vendedor_id)
                .IsRequired();

            // Producto -> DetalleVenta | uno a muchos
            modelBuilder.Entity<Producto>()
                .HasMany<DetalleVenta>()
                .WithOne()
                .HasForeignKey(u => u.producto_id)
                .IsRequired();

            // MetodoPago -> Venta | uno a uno /dasdasdsaaaaaa alveres
            modelBuilder.Entity<MetodoPago>()
                .HasMany<Venta>()
                .WithOne()
                .HasForeignKey(u => u.metodoPago_id)
                .IsRequired();

            // TipoPago -> MetodoPago | uno a muchos 
            modelBuilder.Entity<TipoPago>()
                .HasMany<MetodoPago>()
                .WithOne()
                .HasForeignKey(u => u.tipoPago_id)
                .IsRequired();

            // Cliente -> Documento | uno a muchos
            modelBuilder.Entity<Cliente>()
                .HasMany<Documento>()
                .WithOne()
                .HasForeignKey(u => u.cliente_id)
                .IsRequired();

            // Cliente -> OrdenServicioTecnico | uno a mucho
            modelBuilder.Entity<Cliente>()
                .HasMany<OrdenServicioTecnico>()
                .WithOne()
                .HasForeignKey(u => u.cliente_id)
                .IsRequired();

            // OrdenServicioTenico -> DetalleTrabajo | uno a muchos
            modelBuilder.Entity<OrdenServicioTecnico>()
                .HasMany<DetalleTrabajo>()
                .WithOne()
                .HasForeignKey(u => u.ordenServicioTecnico_id)
                .IsRequired();

            // EmpleadoTecnico -> DetalleTrabajo | uno a muchos
            modelBuilder.Entity<EmpleadoTecnico>()
                .HasMany<DetalleTrabajo>()
                .WithOne()
                .HasForeignKey(u => u.empleadoTecnico_id)
                .IsRequired();

            // Cliente -> User | uno a uno 
            modelBuilder.Entity<User>()
                .HasOne<Cliente>()
                .WithOne()
                .HasForeignKey<Cliente>(u => u.user_id)
                .IsRequired(false);
            /* un nuevo cliente sin un usuario, puedes simplemente dejar el campo UserId sin asignar (será null).
            Si en el futuro decides asociar un cliente a un usuario, puedes actualizar el valor del campo UserId con el ID del usuario correspondiente. */
        }

        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<DetalleCompra> detalleCompras { get; set; }
        public DbSet<DetalleVenta> detalleVentas { get; set; }
        public DbSet<Devolucion> devoluciones { get; set; }
        public DbSet<Documento> documentos { get; set; }
        public DbSet<EmpleadoTecnico> empleadoTecnicos { get; set; }
        public DbSet<Estado> estados { get; set; }
        public DbSet<MetodoPago> metodoPagos { get; set; }
        public DbSet<OrdenServicioTecnico> ordenServicioTecnicos { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Proveedor> proveedores { get; set; }
        public DbSet<RecojoAlmacen> recojoAlmacen { get; set; }
        public DbSet<TipoDocumento> tipoDocumentos { get; set; }
        public DbSet<TipoEntrega> tipoEntregas { get; set; }
        public DbSet<TipoPago> tipoPagos { get; set; }
        public DbSet<Vendedor> vendedores { get; set; }
        public DbSet<Venta> ventas { get; set; }
        public DbSet<User> users { get; set; }
    }
}
