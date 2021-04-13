using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuth0Asp5WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class MessagesController : ControllerBase
    {

        [HttpGet("public-message")]
        public IActionResult PublicMessage()
        {
            return Ok(new
            {
                Message = "The API doesn't require an access token to share this message.- from Dotnet"
            });
        }

        [Authorize]
        [HttpGet("protected-message")]
        public IActionResult ProtectedMessage()
        {
            return Ok(new
            {
                Message = "The API successfully validated your access token.- from Dotnet!!!"
            });
        }

    }

}