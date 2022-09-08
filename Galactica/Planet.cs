namespace Galactica
{
    internal class Planet : SpaceObject
    {
        Random rand = new();
        Position position = new Position();
        public PlanetType PlanetType { get; set; }
        public int Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public int RevolutionPeriod { get; set; }
        public List<Moon> MoonList { get; set; } = new();

        public Planet()
        {

        }
        public Planet(string name)
        {
            this.Name = name;
            position.x = rand.Next(20, 201);
            position.y = rand.Next(20, 201);
            ID = i++;
            Diameter = rand.Next(2500000, 6000001);
            RotationPeriod = rand.Next(16, 14001);
            RevolutionPeriod = rand.Next(88, 60001);
            PlanetType = (PlanetType)rand.Next(0, 4);
        }

        public double Distance(int x1, int y1)
        {
            return Math.Sqrt((0 - x1) ^ 2 + (0 - y1) ^ 2) ;
        }

        public virtual void ShowAll()
        {
            Console.WriteLine($"Planet: {Name}\t\tPlanet Type: {PlanetType}\t\tAfstand til solen: {Distance(position.x, position.y)}");

            foreach (Moon moon in MoonList)
            {
                Console.WriteLine($"Måne: {moon.Name}\t\t\t\t\t\tAfstand til {moon.Orbiting.Name}: {moon.Distance(moon.position.x, moon.position.y, position.x, position.y)}");
            }
        }

    }
}
