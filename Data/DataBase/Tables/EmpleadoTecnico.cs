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
        [StringLength(50)]
        public string nombre { get; set; }
        [Required]
        [StringLength(25)]
        public string apellidoPaterno { get; set; }
        [Required]
        [StringLength(25)]
        public string apellidoMaterno { get; set; }
        [Required]
        [Phone]
        public string telefono { get; set; }       
    }
}