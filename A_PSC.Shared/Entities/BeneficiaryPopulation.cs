using System.ComponentModel.DataAnnotations;

namespace A_PSC.Shared.Entities
{
    public class BeneficiaryPopulation
    {
        [Key]
        public int IdBeneficiaryPopulation { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int MenBeneficiaryPopulation { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int WomenBeneficiaryPopulation { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int TotalBeneficiaryPopulation { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int DirectBeneficiariesBeneficiaryPopulation { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public int IndirectBeneficiariesBeneficiaryPopulation { get; set; }

        // Relación con proyecto (si se usa)
        //public int ProjectId { get; set; }
        //public Project? Project { get; set; }
    }
}
