using System.Collections.Generic;

namespace battleship_api.Models
{
    public class AutoPlacement : IShipPlacementStrategy
    {
        public IEnumerable<Ship> ships { get; set; }
        public int rowCount { get; set; }
        public int colCount { get; set; }

        public AutoPlacement(IEnumerable<Ship> ships, int rowCount, int colCount)
        {
            this.ships = ships;
            this.rowCount = rowCount;
            this.colCount = colCount;
        }

        public void PlaceShips()
        {
            throw new System.NotImplementedException();
        }
    }
}
