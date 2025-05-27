using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Splek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Followcontroller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllFollows()
        {
            return Ok();
        }
    }
}
