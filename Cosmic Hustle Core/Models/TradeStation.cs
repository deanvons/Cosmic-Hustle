using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class TradeStation
    {
        public TradeStation(int id)
        {
            Id = id;
            WareHouseStock = new List<WareItemCache>(); // always non-null, starts empty
            MarketListings = new List<MarketListing>();
        }

        public int Id { get; }

        

        public List<MarketListing> MarketListings { get; }

        public List<WareItemCache> WareHouseStock { get; } 
    }
}
