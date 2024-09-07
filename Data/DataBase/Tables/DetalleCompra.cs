using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{
    [Table("detalleCompra")]
    public class DetalleCompra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string producto { get; set; }
        [Required]
        public DateTime fechaCompra { get; set; }
        [Required]
        public int cantidadComprada { get; set; }
        [Required]
        [Precision(7, 2)]
        public decimal precioUnitario { get; set; }
        [Required]
        [Precision(8, 2)]
        public decimal precioTotal { get; set; }
        [Required]
        public int proveedor_id { get; set; }

    }
}