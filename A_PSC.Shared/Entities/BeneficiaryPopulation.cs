using System.ComponentModel.DataAnnotations;

namespace A_PSC.Shared.Entities
{
    public class BeneficiaryPopulation
    {
        [Key]
        public int BeneficiaryPopulationId { get; set; }

        [Required]
        public int BeneficiaryPopulationMen { get; set; }

        [Required]
        public int BeneficiaryPopulationWomen { get; set; }

        [Required]
        public int BeneficiaryPopulationTotal { get; set; }

        [Required]
        public int DirectBeneficiaries { get; set; }

        [Required]
        public int IndirectBeneficiaries { get; set; }

        //public int ProjectId { get; set; }
        //public Project Project { get; set; } = null!;
    }
}
