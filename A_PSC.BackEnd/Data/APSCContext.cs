using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace A_PSC.BackEnd.Data
{
    public class APSCContext : IdentityDbContext<ApplicationUser>
    {
        public APSCContext(DbContextOptions<APSCContext> options) : base(options) { }

    }

}
