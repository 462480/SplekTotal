using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Splek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReactionController : ControllerBase
    {


        [HttpGet]
        public IActionResult GetAllReactions()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetReaction(int id)
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult CreateGame(DataTransformLayer.Game game)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        { 
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateGame(DataTransformLayer.Game game)
        {
            return Ok();
        }
    }
}
