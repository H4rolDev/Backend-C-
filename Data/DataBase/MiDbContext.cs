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

            // Rol -> Usuario | uno a muchos
            modelBuilder.Entity<Rol>()
                .HasMany<Usuario>()
                .WithOne()
                .HasForeignKey(u => u.id_rol)
                .IsRequired();

            // EmpleadoTecnico -> OrdenServicioTecnico | uno a muchos
            modelBuilder.Entity<EmpleadoTecnico>()
                .HasMany<OrdenServicioTecnico>()
                .WithOne()
                .HasForeignKey(u => u.id_empleadoTecnico)
                .IsRequired();

            // Cliente - Usuario | uno a uno
            modelBuilder.Entity<Cliente>()
                .HasOne<Usuario>()
                .WithOne()
                .HasForeignKey<Usuario>(u => u.id_cliente)
                .IsRequired();

            // Cliente -> OrdenServicioTecnico | uno a muchos
            modelBuilder.Entity<Cliente>()
                .HasMany<OrdenServicioTecnico>()
                .WithOne()
                .HasForeignKey(u => u.id_cliente)
                .IsRequired();

            // CLiente - Documento | uno a uno
            modelBuilder.Entity<Documento>()
                .HasOne<Cliente>()
                .WithOne()
                .HasForeignKey<Cliente>(u => u.id_documento)
                .IsRequired();
            
            // Cliente -> ClienteDireccion | uno a uno
            modelBuilder.Entity<ClienteDireccion>()
                .HasOne<Cliente>()
                .WithOne()
                .HasForeignKey<Cliente>(u => u.id_clienteDireccion)
                .IsRequired();

            // Cliente -> Venta | uno a muchos
            modelBuilder.Entity<Cliente>()
                .HasMany<Venta>()
                .WithOne()
                .HasForeignKey(u => u.id_cliente)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Vendedor -> Venta | uno a muchos
            modelBuilder.Entity<Vendedor>()
                .HasMany<Venta>()
                .WithOne()
                .HasForeignKey(u => u.id_vendedor)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // TipoPago -> Venta | uno a uno
            modelBuilder.Entity<TipoPago>()
                .HasOne<Venta>()
                .WithOne()
                .HasForeignKey<Venta>(u => u.id_tipoPago)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // ClienteDireccion -> Delivery | uno a uno
            modelBuilder.Entity<ClienteDireccion>()
                .HasOne<Delivery>()
                .WithOne()
                .HasForeignKey<Delivery>(u => u.id_direccion)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Venta -> DetalleVenta | uno a uno
            modelBuilder.Entity<Venta>()
                .HasOne<DetalleVenta>()
                .WithOne()
                .HasForeignKey<DetalleVenta>(u => u.id_venta)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
            
            // Cliente -> OrdenServicioTecnico | uno a muchos
            modelBuilder.Entity<Cliente>()
                .HasMany<OrdenServicioTecnico>()
                .WithOne()
                .HasForeignKey(u => u.id_cliente)
                .IsRequired();
            
            // Delivery -> Venta | uno a uno
            modelBuilder.Entity<Delivery>()
                .HasOne<Venta>()
                .WithOne()
                .HasForeignKey<Venta>(u => u.id_delivery)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // RecojoAlmacen -> Venta | uno a muchos
            modelBuilder.Entity<RecojoAlmacen>()
                .HasMany<Venta>()
                .WithOne()
                .HasForeignKey(u => u.id_recojoAlmacen)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            // Estado -> Delivery | uno a muchos
            modelBuilder.Entity<Estado>()
                .HasMany<Delivery>()
                .WithOne()
                .HasForeignKey(u => u.id_estado)
                .IsRequired();
            
            // Productos -> DetalleVenta | uno a muchos
            modelBuilder.Entity<Producto>()
                .HasMany<DetalleVenta>()
                .WithOne()
                .HasForeignKey(u => u.id_producto)
                .IsRequired();

            // Estado -> Compra | uno a muchos
            modelBuilder.Entity<Estado>()
                .HasMany<Compra>()
                .WithOne()
                .HasForeignKey(u => u.id_estado)
                .IsRequired();

            // Proveedor -> Compra | uno a muchos
            modelBuilder.Entity<Proveedor>()
                .HasMany<Compra>()
                .WithOne()
                .HasForeignKey(u => u.id_proveedor)
                .IsRequired();

            // Producto -> DetalleCompra | uno a muchos
            modelBuilder.Entity<Producto>()
                .HasMany<DetalleCompra>()
                .WithOne()
                .HasForeignKey(u => u.id_producto)
                .IsRequired();
            
            // TipoProducto -> Producto | uno a muchos

            // Compra -> DetalleCOmpra | uno a muchos
            modelBuilder.Entity<Compra>()
                .HasMany<DetalleCompra>()
                .WithOne()
                .HasForeignKey(u => u.id_compra)
                .IsRequired();

            // TipoProducto -> Categoria | uno a muchos
            modelBuilder.Entity<Categoria>()
                .HasMany<Producto>()
                .WithOne()
                .HasForeignKey(u => u.id_categoria)
                .IsRequired();
        }
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<ClienteDireccion> clienteDirecciones { get; set; }
        public DbSet<Compra> compras { get; set; }
        public DbSet<Delivery> deliverys { get; set; }
        public DbSet<DetalleCompra> detalleCompras { get; set; }
        public DbSet<DetalleVenta> detalleVentas { get; set; }
        public DbSet<Documento> documentos { get; set; }
        public DbSet<EmpleadoTecnico> empleadoTecnicos { get; set; }
        public DbSet<Estado> estados { get; set; }
        public DbSet<OrdenServicioTecnico> ordenServicioTecnicos { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Proveedor> proveedores { get; set; }
        public DbSet<RecojoAlmacen> recojoAlmacen { get; set; }
        public DbSet<Rol> roles { get; set; }
        public DbSet<TipoPago> tipoPagos { get; set; }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Vendedor> vendedores { get; set; }
        public DbSet<Venta> ventas { get; set; }
    }
}
