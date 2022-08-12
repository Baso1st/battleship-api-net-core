using battleship_api.Models;
using battleship_api.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace battleship_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BattleShipController : ControllerBase
    {
        private IActiveGamesService _activeGamesService;
        public BattleShipController(IActiveGamesService activeGamesService)
        {
            _activeGamesService = activeGamesService;
        }

        // GET api/<BattleShipController>/5
        [HttpGet("{id}")]
        public int CreateNewGame()
        {
            //var game = new Game();
            return 0;
        }

        // POST api/<BattleShipController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BattleShipController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BattleShipController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
