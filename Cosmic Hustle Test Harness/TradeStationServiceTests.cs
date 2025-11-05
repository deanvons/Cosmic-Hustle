using Cosmic_Hustle_Core.Models;
using Cosmic_Hustle_Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Test_Harness
{
    public class TradeStationServiceTests
    {

        [Fact]
        public void TradeStationService_UpdateWareHouseStock_Should_Be_Updated_With_Provided_WarehouseStock()
        {

            // Arrange
            var tradeStationService = new TradeStationService();
            var tradeStation = new TradeStation(1);
            var providedWareItem = new WareItem();
            var providedWareItemCache = new WareItemCache(1, providedWareItem);
            var providedWareHouseStock = new List<WareItemCache>();
            providedWareHouseStock.Add(providedWareItemCache);
            


            // Act
            tradeStationService.UpdateWareHouseStock(tradeStation, providedWareHouseStock);
            var containsWareItemCacheWithId = tradeStation.WareHouseStock.Contains(providedWareItemCache);

            // Assert
            Assert.True(containsWareItemCacheWithId);
        }


        
    }
}
