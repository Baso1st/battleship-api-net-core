using System;

namespace battleship_api.Models
{
    public abstract class Player
    {

        private int[][] board;
        private IShipPlacementStrategy shipPlacementStrategy;
        private int score;
        private int hits;

        public string Name { get; set; }

        public abstract void PlaceShips();

        public virtual bool HasShips()
        {
            throw new NotImplementedException();
        }

        public virtual bool TakeHit()
        {
            throw new NotImplementedException();
        }

        public virtual bool GetUnhitCells()
        {
            throw new NotImplementedException();
        }

    }
}
