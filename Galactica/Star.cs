namespace Galactica
{
    internal class Star : SpaceObject
    {
        public StarType Type { get; set; }
        public int Temperature { get; set; }
        public List<Planet> PlanetList { get; set; } = new();

        public Star()
        {
            Position SunPos = new();
            SunPos.x = 0;
            SunPos.y = 0;
            ID = i++;
            Name = "Sun";
            Type = StarType.YellowDwarf;
            Temperature = 5578;
        }

        public void ShowPlanetList()
        {
            foreach (Planet planet in PlanetList)
            {
                planet.ShowAll();
                Console.WriteLine("");
            }
        }
    }
}
