using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Data.DataBase.Tables
{

    [Table("users")]
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string PasswordHash { get; set; } 

        [Required]
        [StringLength(255)]
        public string Email { get; set; }
        public string Role { get; set; }
    }
}