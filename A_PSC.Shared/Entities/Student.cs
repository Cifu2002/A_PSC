using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class Student
    {
        [Key]
        public int IdStudent { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "La cédula no puede exceder de 10 caracteres.")]
        public string IdCardStudent { get; set; } = null!;

        [Required]
        [StringLength(45, ErrorMessage = "El nombre no puede exceder de 45 caracteres.")]
        public string FirstNameStudent { get; set; } = null!;

        [StringLength(45, ErrorMessage = "El segundo nombre no puede exceder de 45 caracteres.")]
        public string? MiddleNameStudent { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "El apellido no puede exceder de 45 caracteres.")]
        public string LastNameStudent { get; set; } = null!;

        [StringLength(45, ErrorMessage = "El segundo apellido no puede exceder de 45 caracteres.")]
        public string? SecondLastNameStudent { get; set; }

        public int IdCareerPer { get; set; }

        [Required]
        public char GenderStudent { get; set; }

        public long PhoneStudent { get; set; }

        [ForeignKey("IdCareerPer")]
        public Career Career { get; set; } = null!;

        // Relación 1:N con ProjectParticipations
        public ICollection<ProjectParticipation> ProjectParticipation { get; set; } = new List<ProjectParticipation>();

    }
}
