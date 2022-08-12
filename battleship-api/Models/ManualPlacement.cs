using System.Collections.Generic;

namespace battleship_api.Models
{
    public class ManualPlacement : IShipPlacementStrategy
    {
        public IEnumerable<Ship> ships { get; set; }
        public int rowCount { get; set; }
        public int colCount { get; set; }

        public void PlaceShips()
        {
            throw new System.NotImplementedException();
        }
    }
}
