using Cosmic_Hustle_Core.Models;
using Cosmic_Hustle_Core.Services;
using Cosmic_Hustle_Core.State;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
        public void GameState_Load_Should_Store_Provided_Merchant_And_GeneratedGalaxy()
        {

            // Arrange
            var expectedMerchant = new Merchant(1,"Test");
            var gamestate = new GameState();
            var expectedNumberOfPlanets = 1;
            var options = new GalaxyOptions(expectedNumberOfPlanets);
            var galaxyService = new GalaxyService();

            // Act
            gamestate.Load(expectedMerchant, galaxyService,options);
            var actualNumberOfPlanets = gamestate.Galaxy.Count;

            // Assert
            Assert.Equal(expectedMerchant, gamestate.Player);
            Assert.Equal(expectedNumberOfPlanets, actualNumberOfPlanets);

        }


        [Fact]
        public void GameState_Show_Initial_State_Should_Return_Correct_String()
        {

            // Arrange
            var expectedMerchant = new Merchant(1, "Test");
            var gamestate = new GameState();
            var expectedNumberOfPlanets = 1;
            var options = new GalaxyOptions(expectedNumberOfPlanets);
            var galaxyService = new GalaxyService();



            StringBuilder expectedInitialStateStringBuilder = new StringBuilder();
            expectedInitialStateStringBuilder.Append($"Welcome: {gamestate.Player.Name}\n");
            expectedInitialStateStringBuilder.Append($"Planets: {gamestate.Galaxy.Count}\n");
            var expectedInitialStateString = expectedInitialStateStringBuilder.ToString();

            // Act
            var actualInitialStateString = gamestate.ShowInitialState();

            // Assert
            Assert.Equal(expectedInitialStateString, actualInitialStateString);






        }

  











    }
}
