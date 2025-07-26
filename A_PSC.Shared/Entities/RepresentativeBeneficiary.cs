using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_PSC.Shared.Entities
{
    public class RepresentativeBeneficiary
    {
        [Key]
        public int IdRepresentativeBeneficiary { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(45, ErrorMessage = "El nombre no puede exceder de 45 caracteres.")]
        public required string RepresentativeBeneficiaryName { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(45, ErrorMessage = "La posición no puede exceder de 45 caracteres.")]
        public required string RepresentativeBeneficiaryPosition { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(10, ErrorMessage = "El celular no puede exceder de 10 caracteres.")]
        public required string RepresentativeBeneficiaryPhone { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(30, ErrorMessage = "El correo no puede exceder de 30 caracteres.")]
        public required string RepresentativeBeneficiaryEmail { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        public int IdCooperatingEntityPer { get; set; }

        [ForeignKey(nameof(IdCooperatingEntityPer))]
        public CooperatingEntity? CooperatingEntity { get; set; } = null!;
    }
}
