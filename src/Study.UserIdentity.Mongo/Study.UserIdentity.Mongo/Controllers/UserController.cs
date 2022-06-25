using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Study.UserIdentity.Mongo.DTO;
using Study.UserIdentity.Mongo.Models;

namespace Study.UserIdentity.Mongo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserManager<UserModel> _userManager;

        public UserController(UserManager<UserModel> userManager)
        {
            _userManager = userManager;
        }

        [HttpPost]
        public async Task<IActionResult> Create(UserDTO user)
        {
            if (ModelState.IsValid)
            {
                UserModel appUser = new UserModel
                {
                    UserName = user.Name,
                    Email = user.Email
                };

                IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);
                if (result.Succeeded)
                    return Ok();
                else
                {
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);

                    return BadRequest(result.Errors);
                }
            }

            return BadRequest();
        }
    }
}