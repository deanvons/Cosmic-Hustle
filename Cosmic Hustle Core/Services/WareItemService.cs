using Cosmic_Hustle_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Services
{
    public class WareItemService
    {
        // This is a great kata 
        public SortedSet<WareItem> GenerateRandomWareItems(int numberOfWareItems)
        {

            if (numberOfWareItems > Enum.GetValues(typeof(WareItemName)).Length)
                throw new ArgumentException("Requested more items than available enum values.");

            // Step 1: Get all WareItemName values
            var allNames = Enum.GetValues(typeof(WareItemName)).Cast<WareItemName>().ToList();

            // Step 2: Shuffle
            Random rng = new Random();
            for (int i = allNames.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (allNames[i], allNames[j]) = (allNames[j], allNames[i]);
            }

            // Step 3: Generate items from first N names
            var result = new SortedSet<WareItem>();
            for (int i = 0; i < numberOfWareItems; i++)
            {
                var item = new WareItem
                {
                    Id = i,
                    Name = allNames[i]
                };
                result.Add(item);
            }

            return result;

        }



    }
}
