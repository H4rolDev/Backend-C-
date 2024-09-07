using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{

    [Table("recojoAlmacen")]
    public class RecojoAlmacen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(12)]
        public string dni { get; set; }
        [Required]
        [Phone]
        public string telefono { get; set; }
        [Required]
        public int tipoEntrega_id { get; set; }
        [Required]
        public int estado_id { get; set; }
        [Required]
        public int cliente_id { get; set; }
    }
}