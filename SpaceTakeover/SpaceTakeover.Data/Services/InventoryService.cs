﻿using SpaceTakeover.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Services
{
    public class InventoryService
    {
        public void AddResourceToInventory(Inventory inventory, Resource resource)
        {
            Dictionary<string, Resource> currentInventory = inventory.resources;
            string resourceName = resource.name;

            if (currentInventory.ContainsKey(resourceName))
            {
                //currentInventory[resourceName].addToCurrentQuantity(resource.quantity);
            }
            else
            {
                //inventory.addNewResource(resource);
            }
        }

        public bool ReduceQuantityFromInventory(Inventory inventory, Resource resource, int quantity)
        {
            int currentQuantity = resource.quantity;
            int quantityAfterSubtraction = currentQuantity - quantity;

            bool success = false;

            if(quantityAfterSubtraction >= 0)
            {
                resource.quantity = quantityAfterSubtraction;
                success = true;
            }

            return success;
        }
    }
}
