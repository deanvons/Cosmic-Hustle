using Cosmic_Hustle_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Test_Harness
{
    public class GalaxyOptionsTests
    {

        [Fact]
        public void GalaxyOptions_ShouldBe_Created_With_ProvidedValues()
        {

            // Arrange
            var expectedNumberOfPlanets = 1;
            var expectedNumberOfSolarSystems = 1;
            var providedNumberofPlanets = 1;
            var providedNumberOfSolarSystems = 1;

            // Act
            var galaxyOptions = new GalaxyOptions(providedNumberofPlanets, providedNumberOfSolarSystems);
            var actualNumberOfPlanets = galaxyOptions.NumberOfPlanets;
            var actualNumberOfSolarSystems = galaxyOptions.NumberOfSolarSystems;


            // Assert
            Assert.Equal(expectedNumberOfPlanets, actualNumberOfPlanets);
            Assert.Equal(expectedNumberOfSolarSystems,actualNumberOfSolarSystems);








        }





    }
}
