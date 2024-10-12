using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{

    [Table("clienteDireccion")]
    public class ClienteDireccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(200)]
        public string direccion { get; set; }
        [Required]
        [StringLength(200)]
        public string referencia { get; set; }
        [Required]
        [StringLength(200)]
        public string departamento { get; set; }
        [Required]
        [StringLength(200)]
        public string provincia { get; set; }
        [Required]
        [StringLength(200)]
        public string distrito { get; set; }
    }
}