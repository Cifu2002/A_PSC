using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class Faculty
    {
        [Key]
        public int IdFaculty { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "El código no puede exceder de 10 caracteres.")]
        public string CodeFaculty { get; set; } = null!;

        [Required]
        [StringLength(255, ErrorMessage = "El nombre no puede exceder de 255 caracteres.")]
        public string NameFaculty { get; set; } = null!;

        // Relación 1:N con Careers
        public ICollection<Career> Career { get; set; } = new List<Career>();

    }
}
