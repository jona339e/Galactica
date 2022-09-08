namespace Galactica
{
    internal class Planet : SpaceObject
    {
        Random rand = new();
        public Position position = new Position();
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
            position.x = rand.Next(150, 500);
            position.y = rand.Next(150, 500);
            ID = i++;
            Diameter = rand.Next(2500000, 6000001);
            RotationPeriod = rand.Next(16, 14001);
            RevolutionPeriod = rand.Next(88, 60001);
            PlanetType = (PlanetType)rand.Next(0, 4);
        }

        public double Distance(Star star)
        {
            return Math.Sqrt(Math.Pow((star.SunPos.x - position.x), 2) + Math.Pow((star.SunPos.y - position.y), 2)) ;
        }
        public int ReturnPosX()
        {
            return position.x;
        }
        public int ReturnPosY()
        {
            return position.y;
        }
    }
}
