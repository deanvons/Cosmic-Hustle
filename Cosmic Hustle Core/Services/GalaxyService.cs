using Cosmic_Hustle_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Services
{
    public class GalaxyService
    {

        public GalaxyService() { }
        public List<Planet> GenerateGalaxy(GalaxyOptions options)
        {
            var planets = new List<Planet>();
            for (int i = 0; i < options.NumberOfPlanets; i++)
            {
                var planet = new Planet(i,$"Planet {i}");

                planets.Add(planet);
            }

            return planets;

        }
    }
}
