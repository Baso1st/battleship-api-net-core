using battleship_api.Models;
using System.Collections.Generic;

namespace battleship_api.Services
{
    public class ActiveGamesService: IActiveGamesService
    {
        public IEnumerable<Game> games { get; set; }

    }
}
