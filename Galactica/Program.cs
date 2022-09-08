namespace Galactica
{
	class Program
	{
        static void Main(string[] args)
        {

            Star sun = new Star();

            Planet mercury = new Planet("Mercury");
            Planet venus = new("Venus");
            Planet earth = new("Earth");
            Planet mars = new("Mars");
            Planet jupiter = new("Jupiter");
            Planet saturn = new("Saturn");
            Planet uranus = new("Uranus");
            Planet neptune = new("Neptune");

            
            Moon luna = new Moon("Luna     ", earth);
            Moon titan = new("Titan    ", saturn);
            Moon phobes = new("Phobes   ", saturn);
            Moon europe = new("Europe   ", jupiter);
            Moon deimos = new("Deimos   ", mars);
            Moon gynamedes = new("Gynamedes", jupiter);
            Moon io = new("Io       ", jupiter);
            Moon mimas = new("Mimas    ", saturn);

            luna.Orbiting = earth;
            titan.Orbiting = saturn;
            phobes.Orbiting = saturn;
            europe.Orbiting = jupiter;
            deimos.Orbiting = mars;
            gynamedes.Orbiting = jupiter;
            io.Orbiting = jupiter;
            mimas.Orbiting = saturn;

            sun.PlanetList.Add(mercury);
            sun.PlanetList.Add(venus);
            sun.PlanetList.Add(earth);
            sun.PlanetList.Add(mars);
            sun.PlanetList.Add(jupiter);
            sun.PlanetList.Add(saturn);
            sun.PlanetList.Add(uranus);
            sun.PlanetList.Add(neptune);

            earth.MoonList.Add(luna);
            saturn.MoonList.Add(titan);
            saturn.MoonList.Add(phobes);
            jupiter.MoonList.Add(europe);
            mars.MoonList.Add(deimos);
            jupiter.MoonList.Add(gynamedes);
            jupiter.MoonList.Add(io);
            saturn.MoonList.Add(mimas);

            foreach (Planet planet in sun.PlanetList)
            {
                Console.WriteLine($"Planet:\t{planet.Name}\t\t\tPlanet Type: {planet.PlanetType}\t\tDistance to\tthe Sun: {planet.Distance(sun)}");
                foreach (Moon moon in planet.MoonList)
                {
                    Console.WriteLine($"Moon:\t{moon.Name}\t\t\t\t\t\tDistance to\t{moon.Orbiting.Name}: {moon.Distance(planet)}");
                }
                Console.WriteLine("");
            }


		}
	}
}

