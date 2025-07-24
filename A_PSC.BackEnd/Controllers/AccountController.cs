using A_PSC.BackEnd.Data;
using A_PSC.Shared.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace A_PSC.BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;

        //Administrador de usuarios de la entidad?
        public AccountController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpGet]
        public IActionResult Welcome()
        {
            if (User.Identity == null || !User.Identity.IsAuthenticated)
            {
                return Ok("Tu no estas autenticado");
            }
            return Ok("Tu estas autenticado");
        }

        [Authorize]
        [HttpGet("Profile")]
        public async Task<IActionResult> Profile()
        {
            var currentUser = await userManager.GetUserAsync(User);
            if (currentUser == null)
            {
                return BadRequest();
            }

            var userProfile = new UserProfileDTO
            {
                Id = currentUser.Id,
                Name = currentUser.UserName ?? "",
                Email = currentUser.Email ?? "",
                Phone = currentUser.PhoneNumber ?? "",
            };

            return Ok(userProfile);
        }
    }
}
