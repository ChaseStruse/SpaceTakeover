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

        Resource coal = new Resource()
        {
            name = "Coal",
            quantityPerHour = 50,
            strength = 5
        };

        Resource iron = new Resource()
        {
            name = "Iron",
            quantityPerHour = 35,
            strength = 7
        };

        Resource gold = new Resource()
        {
            name = "Gold",
            quantityPerHour = 20,
            strength = 10
        };

        Resource diamond = new Resource()
        {
            name = "Diamond",
            quantityPerHour = 2,
            strength = 12
        };

        public Resource mine(Player player, int hoursToMine)
        {
            if (playerService.ReduceStamina(player))
            {
                Random random = new Random();
                var randNum = random.Next(0, 100);

                Resource resourceToMine;

                if (randNum >= 0 && randNum <= 35) resourceToMine = coal;
                else if (randNum >= 36 && randNum <= 70) resourceToMine = iron;
                else if (randNum >= 71 && randNum <= 90) resourceToMine = gold;
                else resourceToMine = diamond;

                int difference = resourceToMine.strength - player.mining;
                if (difference <= 0)
                {
                    resourceToMine.quantityMined = resourceToMine.quantityPerHour * hoursToMine;
                }
                else
                {
                    double percentToBeMined = (double)player.mining / (double)resourceToMine.strength;
                    int totalMined = ((int)(resourceToMine.quantityPerHour * percentToBeMined));
                    resourceToMine.quantityMined = totalMined * player.timeToSpendOnTask;
                }
                miningMessage(resourceToMine);
                return resourceToMine;
            }
            else return null;
        }

        public void miningMessage(Resource resourceMined)
        {
            Console.WriteLine($"Congratulations you mined {resourceMined.quantityMined} {resourceMined.name}! These will be placed in your inventory.");
        }
    }
}
