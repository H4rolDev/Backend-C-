using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{
    [Table("devoluciones")]

    public class Devolucion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public DateTime fechaDevolucion { get; set; }
        [Required]
        [StringLength(255)]
        public string? motivoDevolucion { get; set; }
        [Required]
        public int detalleVenta_id { get; set; }
    }
}