using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Apellido { get; set; }
        public string Mail { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Rol { get; set; } = "user";
        public DateTime Creacion { get; set; } = DateTime.UtcNow;
        public Estado Estado { get; set; }
    }
}
