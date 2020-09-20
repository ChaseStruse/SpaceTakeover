using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Data.Services;
using SpaceTakeover.Models;

namespace SpaceTakeover.Tests.Services
{
    class ResourceServiceTests
    {
        private ResourceService resourceService;
        private Resource resource;
        private Player player;
        private Inventory inventory;

        [SetUp]
        public void Setup()
        {
            resourceService = new ResourceService();
            player = new Player();
            inventory = player.inventory;
            resource = new Resource();
        }

        [Test]
        public void GivenResourceToMineCorrectAmountIsReturned()
        {
            resource.strength = 10;
            resource.quantity = 100;
            player.mining = 5;
            
            int actual = resourceService.mineResource(resource, player);
            int expected = 50;

            Assert.AreEqual(expected, actual);
        }
    }
}
