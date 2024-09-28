using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "empleadoTecnico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellidoPaterno = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    apellidoMaterno = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleadoTecnico", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "estados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estados", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellidoPaterno = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    apellidoMaterno = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipoDocumentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoDocumentos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipoEntrega",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    horaFecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoEntrega", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tipoPago",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoPago", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vendedores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellidoPaterno = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    apellidoMaterno = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaContratacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    puesto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendedores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "productos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoria_id = table.Column<int>(type: "int", nullable: false),
                    imagen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    modelo = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    marca = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    precio = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    stock = table.Column<int>(type: "int", nullable: false),
                    garantia = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos", x => x.id);
                    table.ForeignKey(
                        name: "FK_productos_categorias_categoria_id",
                        column: x => x.categoria_id,
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalleCompra",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    producto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    cantidadComprada = table.Column<int>(type: "int", nullable: false),
                    precioUnitario = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    precioTotal = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false),
                    proveedor_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleCompra", x => x.id);
                    table.ForeignKey(
                        name: "FK_detalleCompra_proveedores_proveedor_id",
                        column: x => x.proveedor_id,
                        principalTable: "proveedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "delivery",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ApellidoPaterno = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Telefono = table.Column<long>(type: "bigint", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    EmpresaEnvio = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    tipoEntrega_id = table.Column<int>(type: "int", nullable: false),
                    estado_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_delivery", x => x.id);
                    table.ForeignKey(
                        name: "FK_delivery_estados_estado_id",
                        column: x => x.estado_id,
                        principalTable: "estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_delivery_tipoEntrega_tipoEntrega_id",
                        column: x => x.tipoEntrega_id,
                        principalTable: "tipoEntrega",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "metodoPago",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoPago_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_metodoPago", x => x.id);
                    table.ForeignKey(
                        name: "FK_metodoPago_tipoPago_tipoPago_id",
                        column: x => x.tipoPago_id,
                        principalTable: "tipoPago",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    apellidoPaterno = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    apellidoMaterno = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    user_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_clientes_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "documentos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    numeroDocumento = table.Column<int>(type: "int", nullable: false),
                    tipoDocumento_id = table.Column<int>(type: "int", nullable: false),
                    cliente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documentos", x => x.id);
                    table.ForeignKey(
                        name: "FK_documentos_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_documentos_tipoDocumentos_tipoDocumento_id",
                        column: x => x.tipoDocumento_id,
                        principalTable: "tipoDocumentos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordenServicioTecnico",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    horaInicio = table.Column<TimeSpan>(type: "time", nullable: false),
                    horaFin = table.Column<TimeSpan>(type: "time", nullable: false),
                    cliente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordenServicioTecnico", x => x.id);
                    table.ForeignKey(
                        name: "FK_ordenServicioTecnico_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "recojoAlmacen",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dni = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    telefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoEntrega_id = table.Column<int>(type: "int", nullable: false),
                    estado_id = table.Column<int>(type: "int", nullable: false),
                    cliente_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recojoAlmacen", x => x.id);
                    table.ForeignKey(
                        name: "FK_recojoAlmacen_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recojoAlmacen_estados_estado_id",
                        column: x => x.estado_id,
                        principalTable: "estados",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recojoAlmacen_tipoEntrega_tipoEntrega_id",
                        column: x => x.tipoEntrega_id,
                        principalTable: "tipoEntrega",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ventas",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productos = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    fechaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    totalVenta = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    metodoEntrega = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    cliente_id = table.Column<int>(type: "int", nullable: false),
                    vendedor_id = table.Column<int>(type: "int", nullable: false),
                    metodoPago_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ventas", x => x.id);
                    table.ForeignKey(
                        name: "FK_ventas_clientes_cliente_id",
                        column: x => x.cliente_id,
                        principalTable: "clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ventas_metodoPago_metodoPago_id",
                        column: x => x.metodoPago_id,
                        principalTable: "metodoPago",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ventas_vendedores_vendedor_id",
                        column: x => x.vendedor_id,
                        principalTable: "vendedores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalleTrabajo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ordenServicioTecnico_id = table.Column<int>(type: "int", nullable: false),
                    empleadoTecnico_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleTrabajo", x => x.id);
                    table.ForeignKey(
                        name: "FK_detalleTrabajo_empleadoTecnico_empleadoTecnico_id",
                        column: x => x.empleadoTecnico_id,
                        principalTable: "empleadoTecnico",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleTrabajo_ordenServicioTecnico_ordenServicioTecnico_id",
                        column: x => x.ordenServicioTecnico_id,
                        principalTable: "ordenServicioTecnico",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "detalleVenta",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    producto_id = table.Column<int>(type: "int", nullable: false),
                    cantidad = table.Column<int>(type: "int", nullable: false),
                    preioUnitario = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    impuestos = table.Column<decimal>(type: "decimal(7,2)", precision: 7, scale: 2, nullable: false),
                    venta_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleVenta", x => x.id);
                    table.ForeignKey(
                        name: "FK_detalleVenta_productos_producto_id",
                        column: x => x.producto_id,
                        principalTable: "productos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleVenta_ventas_venta_id",
                        column: x => x.venta_id,
                        principalTable: "ventas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "devoluciones",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    motivoDevolucion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    detalleVenta_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_devoluciones", x => x.id);
                    table.ForeignKey(
                        name: "FK_devoluciones_detalleVenta_detalleVenta_id",
                        column: x => x.detalleVenta_id,
                        principalTable: "detalleVenta",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "id", "nombre" },
                values: new object[,]
                {
                    { 1, "Computadoras" },
                    { 2, "Laptops" },
                    { 3, "Auriculares" },
                    { 4, "Teclado" },
                    { 5, "Componentes" },
                    { 6, "Monitores" }
                });

            migrationBuilder.InsertData(
                table: "productos",
                columns: new[] { "id", "categoria_id", "descripcion", "garantia", "imagen", "marca", "modelo", "precio", "stock" },
                values: new object[,]
                {
                    { 1, 1, "B550M, SSD M.2 1TB, RAM 16GB", 2, "https://www.impacto.com.pe/storage/pc/sm/171570984947559.jpg", "AMD", "Ryzen 7 5700G", 3298.80m, 10 },
                    { 2, 1, "Tarjeta de Video RTX 3050, SSD M.2 1TB, RAM 16GB", 2, "https://www.impacto.com.pe/storage/pc/md/171589130599320.jpg", "Intel", "Core I5 13400F", 2170.50m, 30 },
                    { 3, 1, "Tarjeta de Video RTX 3060TI, SSD M.2 1TB, RAM 32GB", 2, "https://www.impacto.com.pe/storage/pc/sm/171570984947559.jpg", "AMD", "Ryzen 9 5900X", 4239.99m, 10 },
                    { 4, 1, "Tarjeta de Video RTX 4060, SSD M.2 1TB, RAM 32GB", 2, "https://www.impacto.com.pe/storage/pc/sm/171570984947559.jpg", "AMD", "Ryzen 7 5700X", 4198.50m, 10 },
                    { 5, 3, "Con Microfono, Control De Volumen, Almohadillas Suaves", 1, "https://www.impacto.com.pe/storage/pc/md/171572299747960.jpg", "Logitech", "Lightspeed Rgb G733 Gaming", 538.99m, 3 },
                    { 6, 3, "Inalambrico, Con Microfono, Control De Volumen, Almohadillas Suaves", 1, "https://www.impacto.com.pe/storage/products/sm/169099476727139.jpg", "Logitech", "G Pro X Gaming", 638.99m, 3 },
                    { 7, 3, "Inalambrico, Necro C/gris, Gaming Surrow 7.1, C/microfono, Entrada Jack", 1, "https://www.impacto.com.pe/storage/products/sm/168867107289840.jpg", "Gambyte ", "Dark Templar", 128.99m, 3 },
                    { 8, 3, "Inalambrico, Necro C/gris, Gaming Surrow 7.1, C/microfono, Entrada Jack", 1, "https://www.impacto.com.pe/storage/products/sm/168867107289840.jpg", "Gambyte ", "Dark Templar", 128.99m, 3 },
                    { 9, 6, "Color Negro, Gaming 5.1, Bluetooth 5.0, Con Microfono, Control De Volumen, Almohadillas Suaves", null, "https://www.impacto.com.pe/storage/products/sm/169099387290344.jpg", "Gambyte", "Soul", 120.99m, 23 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_user_id",
                table: "clientes",
                column: "user_id",
                unique: true,
                filter: "[user_id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_delivery_estado_id",
                table: "delivery",
                column: "estado_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_delivery_tipoEntrega_id",
                table: "delivery",
                column: "tipoEntrega_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_detalleCompra_proveedor_id",
                table: "detalleCompra",
                column: "proveedor_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_detalleTrabajo_empleadoTecnico_id",
                table: "detalleTrabajo",
                column: "empleadoTecnico_id");

            migrationBuilder.CreateIndex(
                name: "IX_detalleTrabajo_ordenServicioTecnico_id",
                table: "detalleTrabajo",
                column: "ordenServicioTecnico_id");

            migrationBuilder.CreateIndex(
                name: "IX_detalleVenta_producto_id",
                table: "detalleVenta",
                column: "producto_id");

            migrationBuilder.CreateIndex(
                name: "IX_detalleVenta_venta_id",
                table: "detalleVenta",
                column: "venta_id");

            migrationBuilder.CreateIndex(
                name: "IX_devoluciones_detalleVenta_id",
                table: "devoluciones",
                column: "detalleVenta_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_documentos_cliente_id",
                table: "documentos",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_documentos_tipoDocumento_id",
                table: "documentos",
                column: "tipoDocumento_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_metodoPago_tipoPago_id",
                table: "metodoPago",
                column: "tipoPago_id");

            migrationBuilder.CreateIndex(
                name: "IX_ordenServicioTecnico_cliente_id",
                table: "ordenServicioTecnico",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_productos_categoria_id",
                table: "productos",
                column: "categoria_id");

            migrationBuilder.CreateIndex(
                name: "IX_recojoAlmacen_cliente_id",
                table: "recojoAlmacen",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_recojoAlmacen_estado_id",
                table: "recojoAlmacen",
                column: "estado_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_recojoAlmacen_tipoEntrega_id",
                table: "recojoAlmacen",
                column: "tipoEntrega_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ventas_cliente_id",
                table: "ventas",
                column: "cliente_id");

            migrationBuilder.CreateIndex(
                name: "IX_ventas_metodoPago_id",
                table: "ventas",
                column: "metodoPago_id");

            migrationBuilder.CreateIndex(
                name: "IX_ventas_vendedor_id",
                table: "ventas",
                column: "vendedor_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "delivery");

            migrationBuilder.DropTable(
                name: "detalleCompra");

            migrationBuilder.DropTable(
                name: "detalleTrabajo");

            migrationBuilder.DropTable(
                name: "devoluciones");

            migrationBuilder.DropTable(
                name: "documentos");

            migrationBuilder.DropTable(
                name: "recojoAlmacen");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropTable(
                name: "empleadoTecnico");

            migrationBuilder.DropTable(
                name: "ordenServicioTecnico");

            migrationBuilder.DropTable(
                name: "detalleVenta");

            migrationBuilder.DropTable(
                name: "tipoDocumentos");

            migrationBuilder.DropTable(
                name: "estados");

            migrationBuilder.DropTable(
                name: "tipoEntrega");

            migrationBuilder.DropTable(
                name: "productos");

            migrationBuilder.DropTable(
                name: "ventas");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "metodoPago");

            migrationBuilder.DropTable(
                name: "vendedores");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "tipoPago");
        }
    }
}
