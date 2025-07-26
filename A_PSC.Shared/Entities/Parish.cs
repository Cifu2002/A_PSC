using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_PSC.Shared.Entities
{
    public class Parish
    {
        [Key]
        public int IdParish { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(100, ErrorMessage = "El nombre de la parroquia no puede exceder de 100 caracteres.")]
        public required string NameParish { get; set; } = null!;

        [Required(ErrorMessage = "Campo requerido")]
        public int IdCantonPer { get; set; }

        [ForeignKey(nameof(IdCantonPer))]
        public Canton Canton { get; set; } = null!;

        //public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
