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
                new Categoria { id = 3, nombre = "Audifonos" },
                new Categoria { id = 4, nombre = "Teclado" },
                new Categoria { id = 5, nombre = "Componentes" },
                new Categoria { id = 6, nombre = "Monitores" }
                );

            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    id = 1,
                    categoria_id = 1,
                    descripcion = "Un audifono muy bueno para gamers",
                    modelo = "Ryzen",
                    marca = "D234",
                    precio = 88.50m,
                    stock = 3,
                    garantia = 1
                },
                new Producto
                {
                    id = 2,
                    categoria_id = 6,
                    descripcion = "Un monitor muy bueno para gamers",
                    modelo = "Teros",
                    marca = "RGBH 24'",
                    precio = 1200.00m,
                    stock = 23
                },
                new Producto
                {
                    id = 3,
                    categoria_id = 1,
                    descripcion = "Un teclado muy bueno para gamers",
                    modelo = "ReDragon",
                    marca = "70% Keys Blue",
                    precio = 98.50m,
                    stock = 10,
                    garantia = 2
                }
            );


        }
    }
}
