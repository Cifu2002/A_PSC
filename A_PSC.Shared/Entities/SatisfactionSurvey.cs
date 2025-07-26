using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class SatisfactionSurvey
    {
        [Key]
        public int IdSatisfactionSurvey { get; set; }

        [StringLength(255, ErrorMessage = "La descripción no puede exceder de 255 caracteres.")]
        public string? DescriptionSatisfactionSurvey { get; set; }

        public DateTime DateSatisfactionSurvey { get; set; }

        public int IdProjectPer { get; set; }

        [StringLength(255, ErrorMessage = "El objetivo no puede exceder de 255 caracteres.")]
        public string? ObjectiveSatisfactionSurvey { get; set; }

        public string? InstructionsSatisfactionSurvey { get; set; }

        // Relación 1:N con SurveyQuestions
        public ICollection<SurveyQuestion> SurveyQuestion { get; set; } = new List<SurveyQuestion>();
    }
}
