using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class ProjectPhase
    {
        [Key]
        public int IdProjectPhase { get; set; }

        [StringLength(50, ErrorMessage = "El nombre de la fase no puede exceder de 50 caracteres.")]
        public string? NameProjectPhase { get; set; }

        [StringLength(50, ErrorMessage = "El estado de la fase no puede exceder de 50 caracteres.")]
        public string? StateProjectPhase { get; set; }

        [StringLength(255, ErrorMessage = "Las observaciones no pueden exceder de 255 caracteres.")]
        public string? ObservationsProjectPhase { get; set; }

        public int IdTeacherPer { get; set; }

        [ForeignKey("IdTeacherPer")]
        public Teacher Teacher { get; set; } = null!;

    }
}
