using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{
    [Table("detalleVenta")]

    public class DetalleVenta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        [Precision(7, 2)]
        public decimal preioUnitario { get; set; }
        [Required]
        [Precision(7, 2)]
        public decimal impuestos { get; set; }
        [Required]
        public int id_producto{get;set;}
        [Required]
        public int id_venta {get;set;}
    }
}