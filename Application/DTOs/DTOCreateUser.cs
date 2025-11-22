using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class DTOCreateUser
    {
        [Required]
        [MaxLength(50)]
        public required string Nombre { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Apellido { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 7)]
        public required string Dni { get; set; }
        [MaxLength(100)]
        public required string Direccion { get; set; }
        [Phone]
        public required string Telefono { get; set; }
        [Required]
        public required string Username { get; set; }
        [Required]
        public required string Password { get; set; }
        [Required]
        public required string Rol { get; set; }
        [Required]
        public required string Estado { get; set; }
    }
}
