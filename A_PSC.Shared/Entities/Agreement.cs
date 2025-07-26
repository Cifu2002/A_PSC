using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_PSC.Shared.Entities
{
    public class Agreement
    {
        [Key]
        public int IdAgreement { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(10, ErrorMessage = "El código del convenio no puede exceder de 10 caracteres.")]
        public required string CodeAgreement { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(60, ErrorMessage = "El nombre del convenio no puede exceder de 60 caracteres.")]
        public required string NameAgreement { get; set; } = null!;

        [StringLength(255, ErrorMessage = "La descripción no puede exceder de 255 caracteres.")]
        public string? DescriptionAgreement { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(45, ErrorMessage = "La fecha de inicio no puede exceder de 45 caracteres.")]
        public required string StartDateAgreement { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(45, ErrorMessage = "La fecha de fin no puede exceder de 45 caracteres.")]
        public required string EndDateAgreement { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(255, ErrorMessage = "La ubicación no puede exceder de 255 caracteres.")]
        public required string LocationAgreement { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        public int IdCooperatingEntityPer { get; set; }

        // Relación 1:1 con CooperatingEntity
        [ForeignKey(nameof(IdCooperatingEntityPer))]
        public CooperatingEntity CooperatingEntity { get; set; } = null!;
    }
}
