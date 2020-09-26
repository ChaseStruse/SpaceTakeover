using SpaceTakeover.Data.Models;
using SpaceTakeover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public class ResourceService
    {
        private PlayerService playerService = new PlayerService();
        public int mineResource(Resource resourceToMine, Player player, int hoursToMine)
        {
            int playerMining = player.mining;
            int resourceStrength = resourceToMine.strength;
            int difference = resourceStrength - playerMining;
            int availableQuantity = resourceToMine.quantity;

            if (playerService.ReduceStamina(player))
            {
                if (difference <= 0)
                {
                    return resourceToMine.quantity * hoursToMine;
                }
                else
                {
                    double percentToBeMined = (double)playerMining / (double)resourceStrength;
                    int totalMined = ((int)(availableQuantity * percentToBeMined));
                    return totalMined * hoursToMine;
                }
            }
            else return 0;
        }
    }
}
