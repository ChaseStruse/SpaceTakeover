using NUnit.Framework;
using SpaceTakeover.DAL.Models;
using SpaceTakeover.Data.Services;

namespace SpaceTakeoverTests
{
    public class InventoryServiceTests
    {
        private IInventoryService sut;
        private Inventory inventory;
        private Resource resource;
        private Resource resource2;

        [SetUp]
        public void Setup()
        {
            sut = new InventoryService();
            inventory = new Inventory();
            resource = new Resource();
            resource2 = new Resource();
        }

        [Test]
        public void GivenResourceThatCurrentlyExistsInInventoryAddResourceToInventoryUpdatesQuantity()
        {
            resource.QuantityMined = 15;
            sut.AddResourceToInventory(inventory, resource);
            resource2.Name = resource.Name;
            resource2.QuantityMined = 25;
            sut.AddResourceToInventory(inventory, resource2);
            int expected = 40;
            int actual = inventory.Resources[resource.Name].QuantityInInventory;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenResourceNotInInventoryResourceGetsAdded()
        {
            sut.AddResourceToInventory(inventory, resource);
            int expected = 1;
            int actual = inventory.Resources.Count;
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GivenExistingInventoryAndResourceReduceQuantityFromInventoryPerformsCorrectly()
        {
            int reduceQuantityBy = 5;
            resource.QuantityMined = 15;
            sut.AddResourceToInventory(inventory, resource);
            bool success = sut.ReduceQuantityFromInventory(inventory, resource.Name, reduceQuantityBy);
            int expected = 10;
            int actual = inventory.Resources[resource.Name].QuantityInInventory;
            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenAmountToReduceGreaterThanQuantitySuccessIsFalseAndQuantityStaysTheSame()
        {
            int reduceQuantityBy = 5;
            resource.QuantityMined = 1;
            sut.AddResourceToInventory(inventory, resource);
            bool success = sut.ReduceQuantityFromInventory(inventory, resource.Name, reduceQuantityBy);
            int expected = 1;
            int actual = inventory.Resources[resource.Name].QuantityInInventory;
            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }
    }
}
