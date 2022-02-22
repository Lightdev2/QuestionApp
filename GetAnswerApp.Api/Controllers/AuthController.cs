using Microsoft.AspNetCore.Mvc;

namespace GetAnswerApp.Api.Controllers
{
    [ApiController]
    [Route("/api/auth")]
    public class AuthController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, world";
        }
    }
}
