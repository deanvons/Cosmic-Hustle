using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class WareItemCache
    {
        public WareItemCache(int id, WareItem cacheItem, int quantity)
        {
            Id = id;
            CacheItem = cacheItem;
            Quantity = quantity;
        }

        public int Id { get; set; }
       
        public WareItem CacheItem { get; set; }

        public int Quantity { get; set; } = 0;

        

    }
}
