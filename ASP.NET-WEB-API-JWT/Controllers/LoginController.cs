using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_WEB_API_JWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LoginController : ControllerBase
    {

    }
}
