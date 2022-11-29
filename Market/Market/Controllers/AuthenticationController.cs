using Market.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Market.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;

        public AuthenticationController(UserManager<IdentityUser> userManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] UserRegistrationRequest requestDto)
        {
            if (ModelState.IsValid)
            {
                var userExist = await userManager.FindByEmailAsync(requestDto.Email);
                if (userExist != null) 
                {
                    return BadRequest(new AuthResult()
                    {
                        Result = false,
                        Errors = new List<string>() { "Email already exists" }
                    });
                }
                var newUser = new IdentityUser()
                {
                    Email = requestDto.Email,
                    UserName = requestDto.Name
                };
                
                var isCreated = await userManager.CreateAsync(newUser, requestDto.Password);
                if (isCreated.Succeeded)
                {
                    return Ok(new AuthResult()
                    {
                        Result = true
                    }) ;
                }

                return BadRequest(new AuthResult()
                {
                    Result = false,
                    Errors = isCreated.Errors.Select(E => E.Description).ToList()
                });

            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] UserLoginRequest loginRequest)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await userManager.FindByEmailAsync(loginRequest.Email);

                if (existingUser == null)
                {
                    return BadRequest(new AuthResult()
                    {
                        Result = false,
                        Errors = new List<string>() { "email not found" }
                    });
                }

                var isCorrect = await userManager.CheckPasswordAsync(existingUser, loginRequest.Password);

                if (!isCorrect)
                {
                    return BadRequest(ModelState);
                }

                return Ok(new AuthResult()
                {
                    Result = true,
                });
            }

            return BadRequest(ModelState);
        }
    }




}
