using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class Program
    {
        [Key]
        public int IdProgram { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "El código no puede exceder de 10 caracteres.")]
        public string CodeProgram { get; set; } = null!;

        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder de 50 caracteres.")]
        public string NameProgram { get; set; } = null!;

        public int IdDomainPer { get; set; }

        [ForeignKey("IdDomainPer")]
        public Domain Domain { get; set; } = null!;
    }
}
