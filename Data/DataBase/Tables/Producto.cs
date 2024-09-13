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
        [Required]
        public int categoria_id { get; set; }
        
        public string? imagen { get; set; }
        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }
        [Required]
        [StringLength(40)]
        public string modelo { get; set; }
        [Required]
        [StringLength(40)]
        public string marca { get; set; }
        [Required]
        [Precision(7, 2)]
        public decimal precio { get; set; }
        [Required]
        public int stock { get; set; }

        public int? garantia { get; set; }
    }
}
