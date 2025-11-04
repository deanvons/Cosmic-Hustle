using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class WareItem
    {
        public WareItem()
        {

        }
        public WareItem(int id, string name, string description, string type, double weight)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Weight = weight;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public double Weight { get; set; }



    }
}
