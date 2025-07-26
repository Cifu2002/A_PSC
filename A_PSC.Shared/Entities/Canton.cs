using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_PSC.Shared.Entities
{
    public class Canton
    {
        [Key]
        public int IdCanton { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(50, ErrorMessage = "El nombre del cantón no puede exceder de 50 caracteres.")]
        public required string NameCanton { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        public int IdProvincePer { get; set; }

        [ForeignKey(nameof(IdProvincePer))]
        public Province Province { get; set; } = null!;

        // Relación 1:N con Parroquias
        public ICollection<Parish> Parishes { get; set; } = new List<Parish>();
    }
}
