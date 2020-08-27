using SpaceTakeover.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public class InventoryService
    {
        public void addResourceToInventory(Inventory inventory, Resource resource)
        {
            Dictionary<string, Resource> currentInventory = inventory.getResources();
            string resourceName = resource.getName();

            if (currentInventory.ContainsKey(resourceName))
            {
                currentInventory[resourceName].addToCurrentQuantity(resource.getQuantity());
            }
            else
            {
                inventory.addResource(resource);
            }
        }
    }
}
