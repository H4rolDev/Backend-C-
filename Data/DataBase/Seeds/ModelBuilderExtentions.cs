using Data.DataBase.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DataBase.Seeds
{
    public static class ModelBuilderExtentions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { id = 1, nombre = "Computadoras" },
                new Categoria { id = 2, nombre = "Laptops" },
                new Categoria { id = 3, nombre = "Auriculares" },
                new Categoria { id = 4, nombre = "Teclado" },
                new Categoria { id = 5, nombre = "Componentes" },
                new Categoria { id = 6, nombre = "Monitores"}
                );

            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    id = 1,
                    categoria_id = 1,
                    imagen= "https://www.impacto.com.pe/storage/pc/sm/171570984947559.jpg",
                    descripcion = "B550M, SSD M.2 1TB, RAM 16GB",
                    modelo = "Ryzen 7 5700G",
                    marca = "AMD",
                    precio = 3298.80m,
                    stock = 10,
                    garantia = 2
                },
                new Producto
                {
                    id = 2,
                    categoria_id = 1,
                    imagen= "https://www.impacto.com.pe/storage/pc/md/171589130599320.jpg",
                    descripcion = "Tarjeta de Video RTX 3050, SSD M.2 1TB, RAM 16GB",
                    modelo = "Core I5 13400F",
                    marca = "Intel",
                    precio = 2170.50m,
                    stock = 30,
                    garantia = 2
                },
                new Producto
                {
                    id = 3,
                    categoria_id = 1,
                    imagen= "https://www.impacto.com.pe/storage/pc/sm/171570984947559.jpg",
                    descripcion = "Tarjeta de Video RTX 3060TI, SSD M.2 1TB, RAM 32GB",
                    modelo = "Ryzen 9 5900X",
                    marca = "AMD",
                    precio = 4239.99m,
                    stock = 10,
                    garantia = 2
                },
                new Producto
                {
                    id = 4,
                    categoria_id = 1,
                    imagen= "https://www.impacto.com.pe/storage/pc/sm/171570984947559.jpg",
                    descripcion = "Tarjeta de Video RTX 4060, SSD M.2 1TB, RAM 32GB",
                    modelo = "Ryzen 7 5700X",
                    marca = "AMD",
                    precio = 4198.50m,
                    stock = 10,
                    garantia = 2
                },
                new Producto
                {
                    id = 5,
                    categoria_id = 3,
                    imagen= "https://www.impacto.com.pe/storage/pc/md/171572299747960.jpg",
                    descripcion = "Con Microfono, Control De Volumen, Almohadillas Suaves",
                    modelo = "Lightspeed Rgb G733 Gaming",
                    marca = "Logitech",
                    precio = 538.99m,
                    stock = 3,
                    garantia = 1
                },
                new Producto
                {
                    id = 6,
                    categoria_id = 3,
                    imagen="https://www.impacto.com.pe/storage/products/sm/169099476727139.jpg",
                    descripcion = "Inalambrico, Con Microfono, Control De Volumen, Almohadillas Suaves",
                    modelo = "G Pro X Gaming",
                    marca = "Logitech",
                    precio = 638.99m,
                    stock = 3,
                    garantia = 1
                },
                new Producto
                {
                    id = 7,
                    categoria_id = 3,
                    imagen="https://www.impacto.com.pe/storage/products/sm/168867107289840.jpg",
                    descripcion = "Inalambrico, Necro C/gris, Gaming Surrow 7.1, C/microfono, Entrada Jack",
                    modelo = "Dark Templar",
                    marca = "Gambyte ",
                    precio = 128.99m,
                    stock = 3,
                    garantia = 1
                },
                new Producto
                {
                    id = 8,
                    categoria_id = 3,
                    imagen="https://www.impacto.com.pe/storage/products/sm/168867107289840.jpg",
                    descripcion = "Inalambrico, Necro C/gris, Gaming Surrow 7.1, C/microfono, Entrada Jack",
                    modelo = "Dark Templar",
                    marca = "Gambyte ",
                    precio = 128.99m,
                    stock = 3,
                    garantia = 1
                },
                new Producto
                {
                    id = 9,
                    categoria_id = 6,
                    imagen="https://www.impacto.com.pe/storage/products/sm/169099387290344.jpg",
                    descripcion = "Color Negro, Gaming 5.1, Bluetooth 5.0, Con Microfono, Control De Volumen, Almohadillas Suaves",
                    modelo = "Soul",
                    marca = "Gambyte",
                    precio = 120.99m,
                    stock = 23
                }  
            );
        }
    }
}
