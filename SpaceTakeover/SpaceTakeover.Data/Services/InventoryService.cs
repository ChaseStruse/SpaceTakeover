using SpaceTakeover.DAL.Models;
using System;

namespace SpaceTakeover.Data.Services
{
    public interface IInventoryService
    {
        void AddResourceToInventory(Inventory inventory, Resource resource);
        bool ReduceQuantityFromInventory(Inventory inventory, string resourceName, int quantity);
        void DisplayInventory(Player player);
    }
    public class InventoryService : IInventoryService
    {
        public void AddResourceToInventory(Inventory inventory, Resource resource)
        {
            try
            {
                if (inventory.Resources.ContainsKey(resource.Name))
                {
                    inventory.Resources[resource.Name].QuantityInInventory += resource.QuantityMined;
                }
                else
                {
                    resource.QuantityInInventory = resource.QuantityMined;
                    inventory.Resources.Add(resource.Name, resource);
                }
                resource.QuantityMined = 0;
            }
            catch
            {
                Console.WriteLine("Could not add resource");
            }
        }

        public bool ReduceQuantityFromInventory(Inventory inventory, string resourceName, int quantity)
        {
            int currentQuantity = inventory.Resources[resourceName].QuantityInInventory;
            int quantityAfterSubtraction = currentQuantity - quantity;

            bool success = false;

            if(quantityAfterSubtraction >= 0)
            {
                inventory.Resources[resourceName].QuantityInInventory = quantityAfterSubtraction;
                success = true;
            }

            return success;
        }

        public void DisplayInventory(Player player)
        {
            Console.WriteLine("Items in Inventory");
            Console.WriteLine("-------------------------------------------------");
            foreach (Resource item in player.Inventory.Resources.Values)
            {
                Console.WriteLine($"{item.Name} - {item.QuantityInInventory}");
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
