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
    }
}
