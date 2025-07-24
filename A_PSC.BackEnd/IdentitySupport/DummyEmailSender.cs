using A_PSC.BackEnd.Data;
using Microsoft.AspNetCore.Identity;

namespace A_PSC.BackEnd.IdentitySupport
{
    public class DummyEmailSender : IEmailSender<ApplicationUser>
    {
        public Task SendConfirmationLinkAsync(ApplicationUser user, string email, string confirmationLink)
            => Task.CompletedTask;

        public Task SendPasswordResetLinkAsync(ApplicationUser user, string email, string resetLink)
            => Task.CompletedTask;

        public Task SendPasswordResetCodeAsync(ApplicationUser user, string email, string resetCode)
            => Task.CompletedTask;
    }
}
