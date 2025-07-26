using System.ComponentModel.DataAnnotations;

namespace A_PSC.Shared.Entities
{
    public class Province
    {
        [Key]
        public int IdProvince { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(45, ErrorMessage = "El nombre de la provincia no puede exceder de 45 caracteres.")]
        public required string NameProvince { get; set; } = null!;

        // Relación 1:N con Cantones
        public ICollection<Canton> Cantons { get; set; } = new List<Canton>();
    }
}
