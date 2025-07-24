using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_PSC.Shared.Entities
{
    public class Parish
    {
        [Key]
        public int ParishId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre de la parroquia no puede exceder de 100 caracteres.")]
        public string ParishName { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Canton))]
        public int CantonIdPer { get; set; }
        public Canton Canton { get; set; } = null!;

        //public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
