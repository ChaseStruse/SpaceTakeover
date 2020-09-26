using SpaceTakeover.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public class InventoryService
    {
        public void AddResourceToInventory(Inventory inventory, Resource resource, int quantity)
        {

            if (inventory.resources.ContainsKey(resource.name))
            {
                inventory.resources[resource.name].quantity += quantity;
            }
            else
            {
                resource.quantity = quantity;
                inventory.resources.Add(resource.name, resource);
            }
        }

        public bool ReduceQuantityFromInventory(Inventory inventory, string resourceName, int quantity)
        {
            int currentQuantity = inventory.resources[resourceName].quantity;
            int quantityAfterSubtraction = currentQuantity - quantity;

            bool success = false;

            if(quantityAfterSubtraction >= 0)
            {
                inventory.resources[resourceName].quantity = quantityAfterSubtraction;
                success = true;
            }

            return success;
        }
    }
}
