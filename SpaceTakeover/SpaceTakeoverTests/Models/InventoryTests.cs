using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Models;
using System.Collections.Generic;

namespace SpaceTakeoverTests
{
    public class InventoryTests
    {
        private Inventory inventory;

        [SetUp]
        public void Setup()
        {
            this.inventory = new Inventory();
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
            List<Resource> resourceList = new List<Resource>() { resource };
            Inventory _inventory = new Inventory(10, 100, resourceList);
            Assert.AreEqual(resourceList, _inventory.getResources());

        }
    }
}
