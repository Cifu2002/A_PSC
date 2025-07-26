using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_PSC.Shared.Entities
{
    public class SurveyQuestion
    {
        [Key]
        public int IdSurveyQuestion { get; set; }

        [StringLength(255, ErrorMessage = "La pregunta no puede exceder de 255 caracteres.")]
        public string? QuestionSurvey { get; set; }

        [StringLength(255, ErrorMessage = "La respuesta no puede exceder de 255 caracteres.")]
        public string? AnswerSurvey { get; set; }

        public int IdSatisfactionSurveyPer { get; set; }

        [ForeignKey("IdSatisfactionSurveyPer")]
        public SatisfactionSurvey SatisfactionSurvey { get; set; } = null!;
    }
}
