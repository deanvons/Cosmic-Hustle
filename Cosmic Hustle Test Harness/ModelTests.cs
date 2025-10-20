using Cosmic_Hustle_Core.Models;

namespace Cosmic_Hustle_Test_Harness
{
    public class ModelTests
    {
        [Fact]
        public void Merchant_Should_Have_ProvidedPropertyValues_When_Created()
        {

            // Arrange
            var expectedId = 1;
            var expectedName = "name";

            // Act
            var merchant = new Merchant(expectedId, expectedName);

            // Assert
            Assert.Equal(expectedId, merchant.Id);
            Assert.Equal(expectedName, merchant.Name);

        }

        [Fact]
        public void Merchant_Should_Have_Ledger_When_Created()
        {

            // Arrange
            var expectedId = 1;
            var expectedName = "name";

            // Act
            var merchant = new Merchant(expectedId, expectedName);

            // Assert

            Assert.NotNull(merchant.Ledger);

        }

        [Fact]
        public void Ledger_Should_Have_ProvidedPropertyValues_When_Created()
        {

            // Arrange
            var expectedId = 1;

            // Act
            var ledger = new Ledger(expectedId);


            // Assert
            Assert.Equal(expectedId, ledger.Id);

        }


        [Fact]
        public void Ship_Should_Have_ProvidedAndDefaultValues_When_Created()
        {

            // Arrange
            var expectedId = 1;
            var expectedName = "name";
            var expectedCargoCapacity = 1;
            var expectedFuelCapacity = 1;
            var expectedCargoLoad = 1;
            var expectedFuelLevel = 1;
            var expectedSolarSystemTravelRange = 1;

            // Act
            var ship = new Ship(expectedId, expectedName, expectedCargoCapacity, expectedFuelCapacity, expectedCargoLoad, expectedFuelLevel, expectedSolarSystemTravelRange);

            // Assert
            Assert.Equal(expectedId, ship.Id);
            Assert.Equal(expectedName, ship.Name);
            Assert.Equal(expectedCargoCapacity, ship.CargoCapacity);
            Assert.Equal(expectedFuelCapacity, ship.FuelCapacity);
            Assert.Equal(expectedCargoLoad, ship.CargoLoad);
            Assert.Equal(expectedFuelLevel, ship.FuelLevel);
            Assert.Equal(expectedSolarSystemTravelRange, ship.SolarSystemTravelRange);
            Assert.NotNull(ship.CargoBay);

        }


        [Fact]
        public void Planet_Should_Have_ProvidedAndDefaultValues_When_Created()
        {

            // Arrange
            var expectedId = 1;
            var expectedName = "name";


            // Act
            var planet = new Planet(expectedId, expectedName);
            // Assert
            Assert.Equal(expectedId, planet.Id);
            Assert.Equal(expectedName, planet.Name);

        }

        [Fact]
        public void MarketSheet_Should_Have_ProvidedAndDefaultValues_When_Created()
        {

            // Arrange
            var expectedId = 1;

            // Act
            var marketSheet = new MarketSheet(expectedId);

            // Assert
            Assert.Equal(expectedId, marketSheet.Id);

        }

        [Fact]
        public void MarketListing_Should_Have_ProvidedAndDefaultValues_When_Created()
        {

            // Arrange
            var expectedId = 1;
            var expectedPrice = 1;
            var wareItemCache = new WareItemCache(1, null, 1);

            // Act
            var marketListing = new MarketListing(expectedId, expectedPrice, wareItemCache);

            // Assert
            Assert.Equal(expectedId, marketListing.Id);
            Assert.Equal(expectedPrice, marketListing.Price);
            Assert.NotNull(marketListing.WareItemCache);

        }

        [Fact]
        public void WareItem_Should_Have_ProvidedAndDefaultValues_When_Created()
        {

            // Arrange
            int expectedId = 1;
            string expectedName = "name";
            string expectedDescription = "description";
            string expectedType = "type";
            double expectedWeight = 1;

            // Act
            var item = new WareItem(expectedId, expectedName, expectedDescription, expectedType, expectedWeight);

            // Assert
            Assert.Equal(expectedId, item.Id);
            Assert.Equal(expectedName, item.Name);
            Assert.Equal(expectedDescription, item.Description);
            Assert.Equal(expectedType, item.Type);
            Assert.Equal(expectedWeight, item.Weight);

        }



        [Fact]
        public void WareItemCache_Should_Have_ProvidedAndDefaultValues_When_Created()
        {

            // Arrange
            var expectedId = 1;
            var expectedWareItem = new WareItem(1,"","","",1);
            var expectedQuantity = 1;
         

            // Act
            var wareItemCache = new WareItemCache(expectedId, expectedWareItem,expectedQuantity);

            // Assert
            Assert.Equal(expectedId, wareItemCache.Id);
            Assert.Equal(expectedWareItem, wareItemCache.CacheItem);
            Assert.Equal(expectedQuantity, wareItemCache.Quantity);
 
         }
    }
}