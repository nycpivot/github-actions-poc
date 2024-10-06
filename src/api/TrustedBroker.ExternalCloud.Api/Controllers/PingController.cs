using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TrustedBroker.ExternalCloud.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        public ActionResult Get()
        {
            return Ok("Hello");
        }
    }
}
