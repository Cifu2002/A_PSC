using System.ComponentModel.DataAnnotations;

namespace A_PSC.Shared.Entities
{
    public class Province
    {
        [Key]
        public int ProvinceId { get; set; }

        [Required]
        [StringLength(45, ErrorMessage = "El nombre de la provincia no puede exceder de 45 caracteres.")]
        public string ProvinceName { get; set; } = null!;

        public ICollection<Canton> Cantons { get; set; } = new List<Canton>();
    }
}
