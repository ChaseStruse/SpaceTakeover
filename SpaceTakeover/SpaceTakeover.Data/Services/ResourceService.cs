using SpaceTakeover.Data.Models;
using SpaceTakeover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public class ResourceService
    {
        public int mineResource(Resource resourceToMine, Player player)
        {
            int playerMining = player.mining;
            int resourceStrength = resourceToMine.strength;
            int difference = resourceStrength - playerMining;
            int availableQuantity = resourceToMine.quantity;

            if (difference <= 0) return resourceToMine.quantity;

            else
            {
                double percentToBeMined = (double)playerMining / (double)resourceStrength;
                int totalMined = ((int)(availableQuantity * percentToBeMined));
                return totalMined;
            }
        }
    }
}
