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

            
            Moon luna = new Moon("Luna");
            Moon titan = new("Titan");
            Moon phobes = new("Phobes");
            Moon europe = new("Europe");
            Moon deimos = new("Deimos");
            Moon gynamedes = new("Gynamedes");
            Moon io = new("Io");
            Moon mimas = new("Mimas");

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

            sun.ShowPlanetList();


		}
	}
}

