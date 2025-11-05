using Cosmic_Hustle_Core.Models;
using Cosmic_Hustle_Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cosmic_Hustle_Core.State
{
    public class GameState
    {

        public GameState() { }
        public Merchant Player { get; set; } = new Merchant();

        public List<Planet> Galaxy { get; set; } = new List<Planet>();

        public void Load(Merchant newPlayer, GalaxyService galaxyService,GalaxyOptions options)
        {

            Player = newPlayer;
            Galaxy = galaxyService.GenerateGalaxy(options);

        }

        public String ShowInitialState()
        {
            
            StringBuilder initialStateString = new StringBuilder();

            initialStateString.Append($"Welcome: {Player.Name}\n");
            initialStateString.Append($"Planets: {Galaxy.Count}\n");

            return initialStateString.ToString();


        }


    }
}
