using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_PSC.Shared.Entities
{
    public class Canton
    {
        [Key]
        public int CantonId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El nombre del cantón no puede exceder de 50 caracteres.")]
        public string CantonName { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Province))]
        public int ProvinceIdPer { get; set; }
        public Province Province { get; set; } = null!;

        public ICollection<Parish> Parishes { get; set; } = new List<Parish>();
    }
}
