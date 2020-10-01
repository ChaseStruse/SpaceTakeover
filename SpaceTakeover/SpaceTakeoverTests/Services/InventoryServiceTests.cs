using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Data.Services;

namespace SpaceTakeoverTests
{
    public class InventoryServiceTests
    {
        private InventoryService sut;
        private Inventory inventory;
        private Resource resource;
        private Resource resource2;

        [SetUp]
        public void Setup()
        {
            this.sut = new InventoryService();
            this.inventory = new Inventory();
            this.resource = new Resource();
            this.resource2 = new Resource();
        }

        [Test]
        public void GivenResourceThatCurrentlyExistsInInventoryAddResourceToInventoryUpdatesQuantity()
        {
            resource.quantityPerHour = 15;
            sut.AddResourceToInventory(inventory, resource);
            resource2.name = resource.name;
            resource.quantityPerHour = 25;
            sut.AddResourceToInventory(inventory, resource2);
            int expected = 40;
            int actual = inventory.resources[resource.name].quantityInInventory;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenResourceNotInInventoryResourceGetsAdded()
        {
            sut.AddResourceToInventory(inventory, resource);
            int expected = 1;
            int actual = inventory.resources.Count;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenExistingInventoryAndResourceReduceQuantityFromInventoryPerformsCorrectly()
        {
            int reduceQuantityBy = 5;
            resource.quantityMined = 15;
            sut.AddResourceToInventory(inventory, resource);
            bool success = sut.ReduceQuantityFromInventory(inventory, resource.name, reduceQuantityBy);
            int expected = 10;
            int actual = inventory.resources[resource.name].quantityInInventory;
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenAmountToReduceGreaterThanQuantitySuccessIsFalseAndQuantityStaysTheSame()
        {
            int reduceQuantityBy = 5;
            resource.quantityMined = 1;
            sut.AddResourceToInventory(inventory, resource);
            bool success = sut.ReduceQuantityFromInventory(inventory, resource.name, reduceQuantityBy);
            int expected = 1;
            int actual = inventory.resources[resource.name].quantityInInventory;
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }
    }
}
