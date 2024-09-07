using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{
    [Table("ordenServicioTecnico")]

    public class OrdenServicioTecnico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public DateTime fecha {get;set;}
        [Required]
        public TimeSpan horaInicio{get;set;}
        [Required]
        public TimeSpan horaFin{get;set;}
        [Required]
        public int cliente_id {get; set;}
    }
}