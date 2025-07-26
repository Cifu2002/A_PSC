using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    internal class ProjectParticipation
    {
        [Key]
        public int IdParticipation { get; set; }

        public int IdStudentPer { get; set; }
        public int IdTeacherPer { get; set; }

        public int Hours { get; set; }

        [StringLength(45, ErrorMessage = "El rol no puede exceder de 45 caracteres.")]
        public string? Role { get; set; }

        [StringLength(45, ErrorMessage = "El tipo de participante no puede exceder de 45 caracteres.")]
        public string? ParticipantType { get; set; }

        [ForeignKey("IdStudentPer")]
        public Student Student { get; set; } = null!;

        [ForeignKey("IdTeacherPer")]
        public Teacher Teacher { get; set; } = null!;
    }
}
