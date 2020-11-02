using SpaceTakeover.DAL.Models;
using System;

namespace SpaceTakeover.Data.Services
{
    public interface IResourceService
    {
        Resource Mine(Player player, int randomNumberToDetermineResource);
        Resource GetResourceToMine(int randNum);
        void CalculateTotalAmountMined(double difference, Resource resourceToMine, Player player);
        void MiningMessage(Resource resourceMined);
    }
    public class ResourceService : IResourceService
    {
        private readonly Resource coal;
        private readonly Resource iron;
        private readonly Resource gold;
        private readonly Resource diamond;

        public ResourceService()
        {
            coal = new Resource()
            {
                Name = "Coal",
                QuantityPerHour = 50,
                Strength = 5
            };

            iron = new Resource()
            {
                Name = "Iron",
                QuantityPerHour = 35,
                Strength = 7
            };

            gold = new Resource()
            {
                Name = "Gold",
                QuantityPerHour = 20,
                Strength = 10
            };

            diamond = new Resource()
            {
                Name = "Diamond",
                QuantityPerHour = 5,
                Strength = 12
            };
        }

        public Resource Mine(Player player, int randomNumberToDetermineResource)
        {
            var resourceToMine = GetResourceToMine(randomNumberToDetermineResource);
            var difference = resourceToMine.Strength - player.Mining;

            CalculateTotalAmountMined(difference, resourceToMine, player);
            MiningMessage(resourceToMine);
            return resourceToMine;

        }

        public Resource GetResourceToMine(int randNum)
        {
            var resourceToMine = new Resource();

            if (randNum >= 0 && randNum <= 35) resourceToMine = coal;
            else if (randNum >= 36 && randNum <= 70) resourceToMine = iron;
            else if (randNum >= 71 && randNum <= 90) resourceToMine = gold;
            else resourceToMine = diamond;

            return (resourceToMine);
        }

        public void CalculateTotalAmountMined(double difference, Resource resourceToMine, Player player)
        {
            if (difference <= 0)
            {
                resourceToMine.QuantityMined = resourceToMine.QuantityPerHour * player.TimeToSpendOnTask;
            }
            else
            {
                double percentToBeMined = (double)player.Mining / (double)resourceToMine.Strength;
                int totalMined = ((int)(resourceToMine.QuantityPerHour * percentToBeMined));
                resourceToMine.QuantityMined = totalMined * player.TimeToSpendOnTask;
            }
        }

        public void MiningMessage(Resource resourceMined)
        {
            Console.WriteLine($"Congratulations you mined {resourceMined.QuantityMined} {resourceMined.Name}! These will be placed in your inventory.");
        }
    }
}
