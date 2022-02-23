using GetAnswerApp.Core.DTOs;
using GetAnswerApp.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace GetAnswerApp.Api.Controllers
{
    [ApiController]
    [Route("/api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
        }

        [HttpPost]
        [Route("sign-up")]
        public async Task<IActionResult> SignUp(NewUser user)
        {
            return Ok(_authService.SignUp(user));
        }

        [HttpPost]
        [Route("sign-in")]
        public async Task<IActionResult> SignIn(LoginRequest loginRequest)
        {
            var result = await _authService.SignIn(loginRequest);
            return Ok(result);
        }
    }
}
