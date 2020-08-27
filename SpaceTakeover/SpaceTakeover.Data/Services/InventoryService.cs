using SpaceTakeover.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public class InventoryService
    {
        public void AddResourceToInventory(Inventory inventory, Resource resource)
        {
            Dictionary<string, Resource> currentInventory = inventory.getResources();
            string resourceName = resource.getName();

            if (currentInventory.ContainsKey(resourceName))
            {
                currentInventory[resourceName].addToCurrentQuantity(resource.getQuantity());
            }
            else
            {
                inventory.addNewResource(resource);
            }
        }

        public int ReduceQuantityFromInventory(Inventory inventory, Resource resource, int quantity)
        {
            int currentQuantity = resource.getQuantity();
            int quantityAfterSubtraction = currentQuantity - quantity;

            if(quantityAfterSubtraction >= 0)
            {
                resource.setQuantity(quantityAfterSubtraction);
                return quantity;
            }
            else
            {
                return 0;
            }
        }
    }
}
