using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string? Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public string? Ubicacion { get; set; }
        public decimal? Precio { get; set; }
        public int Capacidad { get; set; }
        public DateTime Creacion { get; set; }
    }
}
