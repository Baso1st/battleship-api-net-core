using System;
using System.Collections.Generic;


namespace battleship_api.Models
{
    public class Game
    {
        
        private Player winner;
        private IWinStrategy winStrategy;
        private IEnumerable<Player> players;

        private static int global_id = 0;

        public int Id { get; set; }

        public Game(IEnumerable<Player> players, IWinStrategy winStrategy)
        {
            Id = global_id;
            global_id++;
            this.players = players;
            this.winStrategy = winStrategy;
            foreach(var player in this.players)
            {
                player.PlaceShips();
            }
        }

        public bool HasWinner()
        {
            throw new NotImplementedException();
        }

        public string Fire()
        {
            throw new NotImplementedException();
        }

        public Player GetNextPlayer()
        {
            throw new NotImplementedException();
        }

    }
}
