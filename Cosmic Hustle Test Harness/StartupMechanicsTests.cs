using Cosmic_Hustle_Core.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Test_Harness
{
    public class StartupMechanicsTests
    {
        [Fact]
        public void GameState_Should_Be_Created_With_Empty_States()
        {

            // Arrange
            // Act
            var expectedGameState = new GameState();

            // Assert
            Assert.NotNull(expectedGameState.Galaxy);
            Assert.NotNull(expectedGameState.Player);







        }


        [Fact]
        public void GalaxyState_Should_Create_Random_Planets_Of_Given_Amount()
        {










        }











    }
}
