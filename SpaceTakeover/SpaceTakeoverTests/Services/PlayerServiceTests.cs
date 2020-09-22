using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Data.Services;
using SpaceTakeover.Models;

namespace SpaceTakeover.Tests.Services
{
    class PlayerServiceTests
    {
        PlayerService sut;
        [SetUp]
        public void SetUp()
        {
            sut = new PlayerService();
        }

        [Test]
        public void GivenResourceToMineStaminaIsDecreasedCorrectly()
        {
            Player player = new Player();
            player.stamina = 100;
            player.mining = 10;

            Resource resource = new Resource();
            resource.strength = 10;

            int actual = sut.ReduceStamina(player);
            int expected = 50;

            Assert.AreEqual(expected, actual);
        }
    }
}
