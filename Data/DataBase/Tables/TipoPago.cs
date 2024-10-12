using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{

    [Table("tipoPago")]
    public class TipoPago
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public string descripcion {get;set;}
        [Required]
        public string nombres {get;set;}
        [Required]
        public string apellidos {get;set;}
        [Required]
        public int telefono {get;set;}
        
    }
}