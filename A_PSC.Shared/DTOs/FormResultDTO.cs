namespace A_PSC.Shared.DTOs
{
    public class FormResultDTO
    {
        public bool Succeeded { get; set; }
        public string[] Errors { get; set; } = [];
    }
}
