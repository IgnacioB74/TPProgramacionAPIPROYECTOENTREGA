using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class DTOCreateProduct
    {
        [Required]
        [MaxLength(50)]
        public required string Descripcion { get; set; }
        [Required]
        [MaxLength(50)]
        public required string Categoria { get; set; }
        [Required]
        [Range(0.01, 10000)]
        public required decimal Precio { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 7)]
        public required string Stock { get; set; }
        [MaxLength(100)]
        public required string Imagen { get; set; }
        [Phone]
        public required string Activo { get; set; }
    }
}
