using System.ComponentModel.DataAnnotations;

namespace A_PSC.Shared.Entities
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(10, ErrorMessage = "El código no puede exceder de 10 caracteres.")]
        public required string CodeProduct { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder de 50 caracteres.")]
        public required string NameProduct { get; set; } = null!;

        [StringLength(255, ErrorMessage = "La descripción no puede exceder de 255 caracteres.")]
        public string? DescriptionProduct { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(255, ErrorMessage = "La meta no puede exceder de 255 caracteres.")]
        public required string GoalProduct { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(255, ErrorMessage = "El indicador no puede exceder de 255 caracteres.")]
        public required string IndicatorProduct { get; set; } = null!;

        public ICollection<ProjectActivity> ProjectActivities { get; set; } = new List<ProjectActivity>();
    }
}
