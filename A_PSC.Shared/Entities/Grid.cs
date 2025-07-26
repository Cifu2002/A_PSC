using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class Grid
    {
        [Key]
        [Required]
        [StringLength(10, ErrorMessage = "El código no puede exceder de 10 caracteres.")]
        public string CodeGrid { get; set; } = null!;

        public int IdCareerPer { get; set; }

        [ForeignKey("IdCareerPer")]
        public Career Career { get; set; } = null!;

        // Relación 1:N con Subjects
        public ICollection<Subject> Subject { get; set; } = new List<Subject>();

    }
}
