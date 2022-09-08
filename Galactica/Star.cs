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


        // Man kunne nemt lave nogle foreach loops her, hvor de forskellige resultater bliver vist, men jeg havde allerede lavet en
        // ShowAll metode inde i planet, inden jeg lavede denne her.
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
