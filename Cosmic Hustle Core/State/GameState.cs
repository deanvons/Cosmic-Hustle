using Cosmic_Hustle_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.State
{
    public class GameState
    {
        

        public Merchant Player { get; set; } = new Merchant();

        public List<Planet> Galaxy { get; set; } = new List<Planet>();

    }
}
