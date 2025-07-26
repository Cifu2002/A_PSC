using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class Subject
    {
        [Key]
        public int IdSubject { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "El código no puede exceder de 10 caracteres.")]
        public string CodeSubject { get; set; } = null!;

        [Required]
        [StringLength(60, ErrorMessage = "El nombre no puede exceder de 60 caracteres.")]
        public string NameSubject { get; set; } = null!;

        public string IdGridPer { get; set; } = null!;

        [ForeignKey("IdGridPer")]
        public Grid Grid { get; set; } = null!;

    }
}
