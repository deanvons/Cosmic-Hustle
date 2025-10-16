using Cosmic_Hustle_Core.Models;

namespace Cosmic_Hustle_Test_Harness
{
    public class ModelTests
    {
        [Fact]
        public void Merchant_shouldbe_created_with_provided_prop_values()
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
        public void Merchant_shouldbe_created_with_ledger()
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
        public void Ledger_shouldbe_created_with_provided_prop_values()
        {

            // Arrange
            var expectedId = 1;


            // Act
            var ledger = new Ledger(expectedId);


            // Assert
            Assert.Equal(expectedId, ledger.Id);



        }
    }
}