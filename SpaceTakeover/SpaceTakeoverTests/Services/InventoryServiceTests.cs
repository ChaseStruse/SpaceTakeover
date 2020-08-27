using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Data.Services;
using SpaceTakeover.Models;
using System.Collections.Generic;

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
            _inventoryService.addResourceToInventory(inventory, resource);
            Resource resource2 = new Resource();
            resource2.setQuantity(25);
            _inventoryService.addResourceToInventory(inventory, resource2);
            int expected = 40;
            int actual = inventory.getResources()[resource.getName()].getQuantity();
            Assert.AreEqual(expected, actual);

        }
    }
}
