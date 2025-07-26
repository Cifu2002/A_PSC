using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_PSC.Shared.Entities
{
    public class ProjectActivity
    {
        [Key]
        public int IdProjectActivity { get; set; }

        [StringLength(255, ErrorMessage = "La descripción no puede exceder de 255 caracteres.")]
        public string? DescriptionProjectActivity { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(10, ErrorMessage = "La semana no puede exceder de 10 caracteres.")]
        public required string WeekProjectActivity { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        public DateTime StartDateProjectActivity { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public DateTime EndDateProjectActivity { get; set; }

        [StringLength(255, ErrorMessage = "Las observaciones no pueden exceder de 255 caracteres.")]
        public string? ObservationsProjectActivity { get; set; }

        public int? StudentHoursProjectActivity { get; set; }

        public int? TeacherHoursProjectActivity { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int IdSpecificObjectivePer { get; set; }

        [ForeignKey(nameof(IdSpecificObjectivePer))]
        public SpecificObjective SpecificObjective { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        public int IdProductPer { get; set; }

        [ForeignKey(nameof(IdProductPer))]
        public Product Product { get; set; } = null!;
    }
}
