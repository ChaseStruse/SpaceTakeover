using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Data.Services;

namespace SpaceTakeoverTests
{
    public class InventoryServiceTests
    {
        private InventoryService _inventoryService;
        private Inventory inventory;
        private Resource resource;

        [SetUp]
        public void Setup()
        {
            this._inventoryService = new InventoryService();
            this.inventory = new Inventory();
            this.resource = new Resource();
        }

        [Test]
        public void GivenResourceThatCurrentlyExistsInInventoryAddResourceToInventoryUpdatesQuantity()
        {
            resource.setQuantity(15);
            _inventoryService.AddResourceToInventory(inventory, resource);
            Resource resource2 = new Resource();
            resource2.setQuantity(25);
            _inventoryService.AddResourceToInventory(inventory, resource2);
            int expected = 40;
            int actual = inventory.getResources()[resource.getName()].getQuantity();
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenExistingInventoryAndResourceReduceQuantityFromInventoryPerformsCorrectly()
        {
            int reduceQuantity = 5;
            resource.setQuantity(15);
            _inventoryService.AddResourceToInventory(inventory, resource);
            Resource resourcePulledFromInventory = new Resource();
            resourcePulledFromInventory.setQuantity(_inventoryService.ReduceQuantityFromInventory(inventory, resource, reduceQuantity));
            int expected = 10;
            int actual = inventory.getResources()[resource.getName()].getQuantity();
            Assert.AreEqual(expected, actual);
        }
    }
}
