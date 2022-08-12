namespace battleship_api.Models
{
    public abstract class Ship
    {
        public string Name { get; set; }
        protected int size;

        public Ship(string name)
        {
            this.Name = name;
        }

        public virtual HitReport TakeHit()
        {
            throw new System.NotImplementedException();
        }

        protected virtual HitReport GetHitReport()
        {
            throw new System.NotImplementedException();
        }

    }

    public class AirCraftCarrier : Ship
    {
        public AirCraftCarrier(string name): base(name)
        {
            this.size = 5;
        }
    }

    public class Destroyer : Ship
    {
        public Destroyer(string name) : base(name)
        {
            this.size = 3;
        }
    }


    public class Submarine : Ship
    {
        public Submarine(string name) : base(name)
        {
            this.size = 2;
        }
    }

    public class SmallBoat : Ship
    {
        public SmallBoat(string name) : base(name)
        {
            this.size = 1;
        }
    }
}
