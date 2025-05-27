using DataTransformLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Splek.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {

        public static List<DataTransformLayer.Game> games = new()
        {
            new DataTransformLayer.Game { Id = 1, Title = "Game 1", Body = "This is the first game, Kolven", UserId = 1, Likes = 0, Dislikes = 0 },
            new DataTransformLayer.Game { Id = 2, Title = "Game 2", Body = "This is the second game, Bussen", UserId = 2, Likes = 0, Dislikes = 0 },
            new DataTransformLayer.Game { Id = 3, Title = "Game 3", Body = "This is the third game, Blind-bussen", UserId = 3, Likes = 0, Dislikes = 0 }
        };

        [HttpGet]
        public IActionResult GetAllGames()
        {
            return Ok(games);
        }


        [HttpGet("{id}")]
        public IActionResult GetGame(int id)
        {
            var student = games.Find(x => x.Id == id);
            if (student == null)
            {
                return NotFound("Game not found");
            }
            return Ok(student);
        }
        [HttpPost]
        public IActionResult CreateGame(DataTransformLayer.Game game)
        {

            //adding text to test my github workflow
            game.AddGameToDatabase();

            return Ok(game);
        }



        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = games.Find(x => x.Id == id);
            if (student == null)
            {
                return NotFound("Invalid game details");
            }
            games.Remove(student);
            return Ok(games);
        }
        [HttpPut("{id}")]
        public IActionResult UpdateGame(DataTransformLayer.Game game)
        {
            var gameInList = games.Find(x => x.Id == game.Id);
            if (gameInList == null)
            {
                return NotFound("Invalid game details");
            }
            gameInList.Title = game.Title;
            gameInList.Body = game.Body;
            gameInList.UserId = game.UserId;
            gameInList.Likes = game.Likes;
            gameInList.Dislikes = game.Dislikes;
            return Ok(gameInList);
        }
    }
}
