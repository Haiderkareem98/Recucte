using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Recruit.Form;
using Recruit.Repository;
using Recruit_Form.Migrations;
using Recruit_Form.Model;
using Recruit.Model.Response;

namespace Recruit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthtactionController : ControllerBase
    {


        private readonly UserManager<AppUsers> _userManager;
        private readonly IUserRepository repository1;
        public AuthtactionController(UserManager<AppUsers> userManager,IUserRepository repository)
        {
            _userManager = userManager;
            repository1 = repository;
        }



        [HttpPost("Register")]
        public async Task< IActionResult> Register(RegisterDto registerDto)
        {
          var Regs= await repository1.Registration(registerDto);
            
            
                return Ok(Regs);
                
            
        }
        [HttpPost("RgiesterNewUsser")]
        public async Task<IActionResult> RgiesterNewUsser(UserDto user)
        {
            if (ModelState.IsValid)
            {
                AppUsers appUser = new()
                {
                    UserName = user.Username,
                    Email = user.Email,
                };
                IdentityResult result = await _userManager.CreateAsync(appUser, user.Password);
                if (result.Succeeded)
                {
                    return Ok("Success");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return BadRequest(ModelState);

        }
        [HttpPost]
        public async Task<IActionResult> LogIn(DtoLoginUser login)
        {
            if (ModelState.IsValid)
            {
                 AppUsers? user = await _userManager.FindByNameAsync(login.userName);
                if (user != null)
                {
                    if (await _userManager.CheckPasswordAsync(user, login.password))
                    {
                        return Ok("Token");
                    }
                    else
                    {
                        return Unauthorized();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User Name is invalid");
                }
            }
            return BadRequest(ModelState);
        }

    }
}

