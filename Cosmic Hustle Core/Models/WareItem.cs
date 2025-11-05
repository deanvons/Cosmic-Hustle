using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class WareItem : IComparable<WareItem>
    {
        public WareItem()
        {

        }
        public WareItem(int id, WareItemName name, string description, WareItemType type, double weight)
        {
            Id = id;
            Name = name;
            Description = description;
            Type = type;
            Weight = weight;
        }

        public int Id { get; set; }

        public WareItemName Name { get; set; }

        public string Description { get; set; }

        public WareItemType Type { get; set; }

        public double Weight { get; set; }

        public int CompareTo(WareItem? other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
