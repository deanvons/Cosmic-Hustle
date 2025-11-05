using Cosmic_Hustle_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Services
{
    public class TradeStationService
    {


        public void UpdateWareHouseStock(TradeStation tradeStation, List<WareItemCache> warehouseStock)
        {
            foreach (var wareItemCache in warehouseStock)
            {
                tradeStation.WareHouseStock.Add(wareItemCache);
                
            }

        }




    }
}
