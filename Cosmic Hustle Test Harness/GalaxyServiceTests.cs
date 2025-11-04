using Cosmic_Hustle_Core.Models;
using Cosmic_Hustle_Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Test_Harness
{
    public class GalaxyServiceTests
    {



        [Fact]
        public void GenerateGalaxy_Should_Generate_Planets_According_To_Options()
        {
            // Arrange
            var galaxyService = new GalaxyService();
            var expectedNumberOfPlanets = 1;
            var galaxyOptions = new GalaxyOptions(expectedNumberOfPlanets);

            // Act
            var planetList = galaxyService.GenerateGalaxy(galaxyOptions);
            var actualNumberOfPlanets = planetList.Count;

            // Assert
            Assert.Equal(expectedNumberOfPlanets, actualNumberOfPlanets);


        }


    }
}
