using System.ComponentModel.DataAnnotations;

namespace A_PSC.Shared.Entities
{
    public class Annex
    {
        [Key]
        public int IdAnnex { get; set; }

        /*[Required(ErrorMessage = "Campo requerido")]
        public int IdProjectPer { get; set; }

        [ForeignKey(nameof(IdProjectPer))]
        public Project Project { get; set; } = null!;*/

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(25, ErrorMessage = "El tipo de anexo no puede exceder de 25 caracteres.")]
        public required string TypeAnnex { get; set; } = null!;

        [StringLength(255, ErrorMessage = "La descripción del anexo no puede exceder de 255 caracteres.")]
        public string? DescriptionAnnex { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(255)]
        public required string FileUrlAnnex { get; set; } = null!;
    }
}
