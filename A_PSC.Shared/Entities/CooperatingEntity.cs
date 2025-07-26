using System.ComponentModel.DataAnnotations;

namespace A_PSC.Shared.Entities
{
    public class CooperatingEntity
    {
        [Key]
        public int IdCooperatingEntity { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(10, ErrorMessage = "El código de la entidad cooperante no puede exceder de 10 caracteres.")]
        public required string CodeCooperatingEntity { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(100, ErrorMessage = "El nombre de la entidad cooperante no puede exceder de 100 caracteres.")]
        public required string NameCooperatingEntity { get; set; } = null!;

        // Relación 1:N con aportes
        public ICollection<CooperatingEntityContribution> Contributions { get; set; } = new List<CooperatingEntityContribution>();
    }
}
