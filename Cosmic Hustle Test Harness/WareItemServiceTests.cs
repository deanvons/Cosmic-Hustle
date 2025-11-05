using Cosmic_Hustle_Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Test_Harness
{
    public class WareItemServiceTests
    {

        [Fact]
        public void WareItemService_GenerateRandomWareItems_Should_Generate_N_Random_Wares()
        {

            // Arrange
            var expectedNumberOfWareItems = 1;
            var wareItemService = new WareItemService();


            // Act
            var actualGeneratedWareItems = wareItemService.GenerateRandomWareItems(expectedNumberOfWareItems);
            var actualNumberOfWareItems = actualGeneratedWareItems.Count();


            // Assert
            Assert.Equal(expectedNumberOfWareItems, actualNumberOfWareItems);











        }








    }
}
