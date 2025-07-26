using System.ComponentModel.DataAnnotations;

namespace A_PSC.Shared.Entities
{
    public class SpecificObjective
    {
        [Key]
        public int IdSpecificObjective { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(255, ErrorMessage = "La descripción no puede exceder de 255 caracteres.")]
        public required string DescriptionSpecificObjective { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(255, ErrorMessage = "La meta no puede exceder de 255 caracteres.")]
        public required string GoalSpecificObjective { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(255, ErrorMessage = "El indicador no puede exceder de 255 caracteres.")]
        public required string IndicatorSpecificObjective { get; set; } = null!;

        public ICollection<ProjectActivity> ProjectActivities { get; set; } = new List<ProjectActivity>();
        /*[Required(ErrorMessage = "Campo requerido")]
        public int IdProjectPer { get; set; }

        [ForeignKey(nameof(IdProjectPer))]
        public Project Project { get; set; } = null!;*/
    }
}
