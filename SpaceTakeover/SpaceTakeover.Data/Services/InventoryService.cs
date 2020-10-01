using SpaceTakeover.Data.Models;
using SpaceTakeover.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public class InventoryService
    {
        public void AddResourceToInventory(Inventory inventory, Resource resource)
        {
            try
            {
                if (inventory.resources.ContainsKey(resource.name))
                {
                    inventory.resources[resource.name].quantityInInventory += resource.quantityMined;
                }
                else
                {
                    resource.quantityInInventory = resource.quantityMined;
                    inventory.resources.Add(resource.name, resource);
                }
                resource.quantityMined = 0;
            }
            catch
            {
                Console.WriteLine("Could not add resource");
            }
        }

        public bool ReduceQuantityFromInventory(Inventory inventory, string resourceName, int quantity)
        {
            int currentQuantity = inventory.resources[resourceName].quantityInInventory;
            int quantityAfterSubtraction = currentQuantity - quantity;

            bool success = false;

            if(quantityAfterSubtraction >= 0)
            {
                inventory.resources[resourceName].quantityInInventory = quantityAfterSubtraction;
                success = true;
            }

            return success;
        }

        public void DisplayInventory(Player player)
        {
            Console.WriteLine("Items in Inventory");
            Console.WriteLine("-------------------------------------------------");
            foreach (Resource item in player.inventory.resources.Values)
            {
                Console.WriteLine($"{item.name} - {item.quantityInInventory}");
            }
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
