namespace Galactica
{
    internal abstract class SpaceObject
    {
        public int i = 0;
        public int ID { get; set; }
        public string Name { get; set; }

        public class Position
        {
            public int x;
            public int y;
            public override string ToString()
            {
                return "(" + x + "," + y + ")";
            }
        }
        public enum StarType { YellowDwarf, White, BlueNeutron, RedGiant }
        public enum PlanetType { Terrestial, Giant, Dwarf, Gas_Giant }

    }
}
