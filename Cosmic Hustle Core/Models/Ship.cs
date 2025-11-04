using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.Models
{
    public class Ship
    {
        public Ship() { }


        public Ship(int id, string name, double cargoCapacity, double fuelCapacity, double cargoLoad, double fuelLevel, int solarSystemTravelRange)
        {
            Id = id;
            Name = name;
            CargoCapacity = cargoCapacity;
            FuelCapacity = fuelCapacity;
            CargoLoad = cargoLoad;
            FuelLevel = fuelLevel;
            SolarSystemTravelRange = solarSystemTravelRange;
        }

        public int Id { get;set; }
        public string Name { get; set; }
        public double CargoCapacity { get; set; }
        public double FuelCapacity { get; set; }
        public double CargoLoad { get; set; }
        public double FuelLevel { get; set; }
        public int SolarSystemTravelRange { get; set; }

        public List<WareItem> CargoBay { get; set; } = new List<WareItem>();

    }
}
