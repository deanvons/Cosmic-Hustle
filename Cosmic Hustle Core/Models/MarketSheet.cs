using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class MarketSheet
    {
        public MarketSheet(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        public List<MarketListing> Listings { get; set; } = new List<MarketListing>();
    }
}
