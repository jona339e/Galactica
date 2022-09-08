namespace Galactica
{
    internal class Star : SpaceObject
    {
        public Position SunPos = new();
        public StarType Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet> PlanetList { get; set; } = new();

        public Star()
        {
            
            SunPos.x = 0;
            SunPos.y = 0;
            ID = i++;
            Name = "Sun";
            Type = StarType.YellowDwarf;
            Temperature = 5578;
        }
    }
}
