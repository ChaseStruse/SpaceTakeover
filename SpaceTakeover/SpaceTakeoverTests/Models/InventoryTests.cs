using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Data.Services;
using SpaceTakeover.Models;
using System.Collections.Generic;

namespace SpaceTakeoverTests
{
    public class InventoryTests
    {
        private Inventory inventory;
        private InventoryService _inventoryService;

        [SetUp]
        public void Setup()
        {
            this.inventory = new Inventory();
            this._inventoryService = new InventoryService();
        }

        [Test]
        public void GivenInventorySizeGetAndSetMethodsReturnProperly()
        {
            int size = 100;
            inventory.setSize(size);
            int actual = inventory.getSize();
            Assert.AreEqual(size, actual);
        }

        [Test]
        public void GivenInventoryMaxSizeGetAndSetMethodsReturnProperly()
        {
            int maxSize = 150;
            inventory.setMaxSize(maxSize);
            int actual = inventory.getMaxSize();
            Assert.AreEqual(maxSize, actual);
        }

        [Test]
        public void GivenResourceGetResourceReturnsProperly()
        {
            Resource resource = new Resource();
            Dictionary<string, Resource> resourceList = new Dictionary<string, Resource>() {
                { resource.getName(),resource }
            };
            _inventoryService.AddResourceToInventory(inventory, resource);
            Assert.AreEqual(resourceList, inventory.getResources());

        }

        public void GivenSpecificResourceGetSpecificResourceReturnsProperly()
        {
            int quantity = 15;
            int quantitySubtracted = 5;
            Resource resource = new Resource();
            resource.setQuantity(quantity);
            _inventoryService.AddResourceToInventory(inventory, resource);
            Resource resourceTakingQuantity = new Resource();
            resourceTakingQuantity.setQuantity(_inventoryService.ReduceQuantityFromInventory(inventory, resource, quantity));


        }
    }
}
