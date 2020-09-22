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
        private Resource resource2;

        [SetUp]
        public void Setup()
        {
            this._inventoryService = new InventoryService();
            this.inventory = new Inventory();
            this.resource = new Resource();
            this.resource2 = new Resource();
        }

        [Test]
        public void GivenResourceThatCurrentlyExistsInInventoryAddResourceToInventoryUpdatesQuantity()
        {
            resource.quantity = 15;
            _inventoryService.AddResourceToInventory(inventory, resource);
            resource2.name = resource.name;
            resource2.quantity = 25;
            _inventoryService.AddResourceToInventory(inventory, resource2);
            int expected = 40;
            int actual = inventory.resources[resource.name].quantity;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenResourceNotInInventoryResourceGetsAdded()
        {
            _inventoryService.AddResourceToInventory(inventory, resource);
            int expected = 1;
            int actual = inventory.resources.Count;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenExistingInventoryAndResourceReduceQuantityFromInventoryPerformsCorrectly()
        {
            int reduceQuantityBy = 5;
            resource.quantity = 15;
            _inventoryService.AddResourceToInventory(inventory, resource);
            bool success = _inventoryService.ReduceQuantityFromInventory(inventory, resource.name, reduceQuantityBy);
            int expected = 10;
            int actual = inventory.resources[resource.name].quantity;
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenAmountToReduceGreaterThanQuantitySuccessIsFalseAndQuantityStaysTheSame()
        {
            int reduceQuantityBy = 5;
            resource.quantity = 1;
            _inventoryService.AddResourceToInventory(inventory, resource);
            bool success = _inventoryService.ReduceQuantityFromInventory(inventory, resource.name, reduceQuantityBy);
            int expected = 1;
            int actual = inventory.resources[resource.name].quantity;
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }
    }
}
