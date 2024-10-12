using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{
    [Table("productos")]
    public class Producto
    {
        [Key]
        public int id { get; set; }
        public int id_categoria { get; set; }
        public string? imagen { get; set; }
        [Required]
        [StringLength(250)]
        public string descripcion { get; set; }
        [Required]
        [StringLength(250)]
        public string modelo { get; set; }
        [Required]
        [StringLength(250)]
        public string marca { get; set; }
        [Required]
        public decimal precioVenta { get; set; }
        [Required]
        public int stock { get; set; }
        public int? garantia { get; set; }
        public string? PorcUtilidad { get; set; }  
        [Required]
        public bool estado { get; set; }
    }
}
