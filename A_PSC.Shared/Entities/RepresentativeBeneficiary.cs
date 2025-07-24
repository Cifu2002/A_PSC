using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_PSC.Shared.Entities
{
    public class RepresentativeBeneficiary
    {
        [Key]
        public int RepresentativeBeneficiaryId { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "El nombre no puede exceder de 45 caracteres.")]
        public string RepresentativeBeneficiaryName { get; set; } = null!;

        [Required]
        [StringLength(45, ErrorMessage = "La posición no puede exceder de 45 caracteres.")]
        public string RepresentativeBeneficiaryPosition { get; set; } = null!;

        [Required]
        [StringLength(10, ErrorMessage = "El celular no puede exceder de 10 caracteres.")]
        public string RepresentativeBeneficiaryPhone { get; set; } = null!;

        [Required]
        [StringLength(30, ErrorMessage = "El correo no puede exceder de 30 caracteres.")]
        public string RepresentativeBeneficiaryEmail { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(CooperatingEntity))]
        public int CooperatingEntityIdPer { get; set; }
        public CooperatingEntity CooperatingEntity { get; set; } = null!;
    }
}
