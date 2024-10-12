using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{

    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string RSocial { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombres { get; set; }
        [Required]
        [StringLength(100)]
        public string Apellidos { get; set; }
        [Required]
        [Phone]
        public string telefono { get; set; }
        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string correo { get; set; }
        public int id_documento { get; set; }
        public int id_clienteDireccion { get; set; }

    }
}