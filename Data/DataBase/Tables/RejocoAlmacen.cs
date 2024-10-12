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
        [StringLength(100)]
        public string nombre { get; set; }
        [Required]
        [StringLength(100)]
        public string apellidos { get; set; }
        [Required]
        [Phone]
        public string telefono { get; set; }
        [Required]
        public string correo { get; set; }
    }
}