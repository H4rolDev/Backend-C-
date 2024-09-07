using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{
    [Table("ventas")]

    public class Venta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string productos{get;set;}
        [Required]
        public DateTime fechaCompra {get;set;}
        [Required]
        [Precision(7, 2)]
        public decimal totalVenta {get;set;}
        [Required]
        [StringLength(20)]
        public string metodoEntrega{get;set;}
        [Required]
        public int cliente_id{get;set;}
        [Required]
        public int vendedor_id{get;set;}
        [Required]
        public int metodoPago_id{get;set;}

        
    }
}