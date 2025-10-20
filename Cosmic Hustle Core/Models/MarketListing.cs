using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class MarketListing
    {
        public MarketListing(int id, double price, WareItemCache wareItemCache)
        {
            Id = id;
            Price = price;
            WareItemCache = wareItemCache;
        }

        public int Id { get; set; }

        public WareItemCache WareItemCache { get; set; }

        public double Price { get; set; }

    }
}
