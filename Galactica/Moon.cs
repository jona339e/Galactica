﻿using System.Drawing;

namespace Galactica
{
    internal sealed class Moon : Planet
    {
        public Random rand = new();
        public Position position = new Position();
        public Planet Orbiting { get; set; }

        public Moon(string name, Planet planet = null)
        {
            this.Name = name;
            if (planet != null)
            {
                position.x = planet.ReturnPosX() - rand.Next(2, 8);
                position.y = planet.ReturnPosY() - rand.Next(10, 80);
            }
            
            
            ID = i++;
            Diameter = rand.Next(2500000, 6000001);
            RotationPeriod = rand.Next(16, 14001);
            RevolutionPeriod = rand.Next(88, 60001);
        }

        public double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2 )+ Math.Pow((y1 - y2), 2));
        }
    }
}
