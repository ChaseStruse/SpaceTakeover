using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Data.Services;
using SpaceTakeover.Models;

namespace SpaceTakeover.Tests.Services
{
    class ResourceServiceTests
    {
        private ResourceService sut;
        private Resource resource;
        private Player player;
        private Inventory inventory;

        [SetUp]
        public void Setup()
        {
            sut = new ResourceService();
            player = new Player();
            inventory = player.inventory;
            resource = new Resource();
        }

        [Test]
        public void GivenResourceToMineHalfOfResourceQuantityIsReturned()
        {
            resource.strength = 10;
            resource.quantity = 100;
            player.mining = 5;
            player.stamina = 100;
            player.timeToSpendOnTask = 1;
            int actual = sut.mineResource(resource, player, player.timeToSpendOnTask);
            int expected = 50;

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GivenPlayerMiningAndResourceStrengthAreEqualFullQuantityReturned()
        {
            resource.strength = 10;
            resource.quantity = 100;
            player.mining = 10;
            player.stamina = 100;
            player.timeToSpendOnTask = 1;
            int actual = sut.mineResource(resource, player, player.timeToSpendOnTask);
            int expected = 100;

            Assert.AreEqual(expected, actual);
        }
    }
}
