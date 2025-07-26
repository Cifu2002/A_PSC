using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_PSC.Shared.Entities
{
    public class CooperatingEntityContribution
    {
        [Key]
        public int IdCooperatingEntityContribution { get; set; }

        [StringLength(255, ErrorMessage = "La descripción no puede exceder de 255 caracteres.")]
        public string? DescriptionCooperatingEntityContribution { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [Column(TypeName = "decimal(12,2)")]
        public decimal ValueCooperatingEntityContribution { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int IdCooperatingEntityPer { get; set; }

        [ForeignKey(nameof(IdCooperatingEntityPer))]
        public CooperatingEntity CooperatingEntity { get; set; } = null!;
    }
}
