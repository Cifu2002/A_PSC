using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class Career
    {
        [Key]
        public int IdCareer { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "El código no puede exceder de 10 caracteres.")]
        public string CodeCareer { get; set; } = null!;

        [Required]
        [StringLength(255, ErrorMessage = "El nombre no puede exceder de 255 caracteres.")]
        public string NameCareer { get; set; } = null!;

        public int IdFacultyPer { get; set; }

        [ForeignKey("IdFacultyPer")]
        public Faculty Faculty { get; set; } = null!;

        // Relaciones 1:N
        public ICollection<Grid> Grid { get; set; } = new List<Grid>();
        public ICollection<Student> Student { get; set; } = new List<Student>();
        public ICollection<Teacher> Teacher { get; set; } = new List<Teacher>();

    }
}
