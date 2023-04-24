using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Abstract;

namespace WebApi_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        //api/auth/
        [HttpPost]
        public async Task<IActionResult> CreateToken()
        {
            var result = await _authService.CreateTokenAsync();

            return Ok(result);
            //Test
        }
    }
}
