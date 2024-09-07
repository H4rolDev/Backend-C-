using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.DataBase.Tables
{
    [Table("delivery")]
    public class Delivery
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(255)] // Puedes ajustar el tamaño máximo si es necesario
        public string Nombre { get; set; }

        [Required]
        [MaxLength(255)]
        public string ApellidoPaterno { get; set; }

        [Required]
        [Range(10000000, 99999999)] // Ajuste de rango para un DNI de 8 dígitos
        public string DNI { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(255)]
        public string Correo { get; set; }

        [Required]
        [Phone]
        public long Telefono { get; set; }

        [Required]
        [MaxLength(500)]
        public string Direccion { get; set; }

        [Required]
        [MaxLength(255)]
        public string EmpresaEnvio { get; set; }
        [Required]
        public int tipoEntrega_id { get; set; }
        [Required]
        public int estado_id { get; set; }
    }
}