using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class Teacher
    {
        [Key]
        public int IdTeacher { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "La cédula no puede exceder de 10 caracteres.")]
        public string IdCardTeacher { get; set; } = null!;

        public int IdCareerPer { get; set; }

        [ForeignKey("IdCareerPer")]
        public Career Career { get; set; } = null!;

        // Relaciones 1:N
        public ICollection<ProjectParticipation> ProjectParticipation { get; set; } = new List<ProjectParticipation>();
        public ICollection<ProjectPhase> ProjectPhase { get; set; } = new List<ProjectPhase>();
    }
}
