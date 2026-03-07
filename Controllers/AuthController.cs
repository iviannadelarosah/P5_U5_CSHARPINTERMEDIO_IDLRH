using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using P5_U5_CSHARPINTERMEDIO_IDLRH.Models;

namespace P5_U5_CSHARPINTERMEDIO_IDLRH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            return Ok();
        }

        [HttpPost("refresh")]
        public IActionResult Refresh([FromBody] RefreshRequest request)
        {
            return Ok();
        }
    }
}
