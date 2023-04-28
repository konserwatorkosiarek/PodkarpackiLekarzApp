using Microsoft.AspNetCore.Mvc;
using PodkarpackiLekarz.Api.Requests;

namespace PodkarpackiLekarz.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IdentityController : ControllerBase
    {
        [HttpPost]
        [Route("signIn")]
        public IActionResult SignIn([FromBody]SignInRequest request)
        {
            return Ok();
        }
    }
}
