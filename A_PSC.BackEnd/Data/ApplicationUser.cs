using Microsoft.AspNetCore.Identity;

namespace A_PSC.BackEnd.Data
{
    public class ApplicationUser : IdentityUser //Hereda de la clase IdentityUser para crear campos adicionales a los que viene por defecto
    {
        public string? IdentificationNumber { get; set; } = null!;
        public string? FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string? LastName { get; set; } = null!;
        public string? SecondLastName { get; set; }
        public int? CareerId { get; set; }
        public string? FacultyCoordinator { get; set; } = null!;
        public string? Gender { get; set; } = null!;
        public bool? IsActive { get; set; } = true;

    }
}
