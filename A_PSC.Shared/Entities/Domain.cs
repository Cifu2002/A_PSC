using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class Domain
    {
        [Key]
        public int IdDomain { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "El código no puede exceder de 10 caracteres.")]
        public string CodeDomain { get; set; } = null!;

        [Required]
        [StringLength(80, ErrorMessage = "El nombre no puede exceder de 80 caracteres.")]
        public string NameDomain { get; set; } = null!;

        [StringLength(255, ErrorMessage = "La descripción no puede exceder de 255 caracteres.")]
        public string? DescriptionDomain { get; set; }

        // Relación 1:N con Programs
        public ICollection<Program> Program { get; set; } = new List<Program>();

    }
}
