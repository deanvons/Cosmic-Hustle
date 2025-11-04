using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class Planet
    {
        public Planet(int id, string name)
        {
            Id = id;
            Name = name;
            TradeStation = new TradeStation(id);
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public TradeStation TradeStation { get; set; }
    }
}
