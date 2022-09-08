using System.Drawing;

namespace Galactica
{
    internal sealed class Moon : Planet
    {
        public Random rand = new();
        public Position position = new Position();
        public Planet Orbiting { get; set; }

        public Moon(string name)
        {
            this.Name = name;
            position.x = rand.Next(20, 200001);
            position.y = rand.Next(20, 200001);
            ID = i++;
            Diameter = rand.Next(2500000, 6000001);
            RotationPeriod = rand.Next(16, 14001);
            RevolutionPeriod = rand.Next(88, 60001);
            PlanetType = (PlanetType)rand.Next(0, 4);
        }

        public double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
        }
    }
}
