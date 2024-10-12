using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{
    [Table("proveedores")]

    public class Proveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string RSocial { get; set; }
        [Required]
        public int RUC { get; set; }
        [Required]
        [Phone]
        public int telefono { get; set; }
        [Required]
        [StringLength(50)]
        [EmailAddress]
        public string correo { get; set; }
        public string nombreContacto { get; set; }   
        public int telefonoContacto { get; set; }

    }
}