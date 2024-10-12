using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{
    [Table("empleadoTecnico")]

    public class EmpleadoTecnico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        public string nombres { get; set; }
        [Required]
        [StringLength(100)]
        public string apellidos { get; set; }
  
        public int salario { get; set; }
        [Required]
        [Phone]
        public string telefono { get; set; }       
    }
}