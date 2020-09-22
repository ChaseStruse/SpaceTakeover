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
        public void GivenTimeSpentOfZeroStaminaIsNotReducedAndSuccessIsFalse()
        {
            Player player = new Player();
            player.stamina = 100;

            int timeSpent = 0;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 100;

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }

        [Test]
        public void GivenTimeSpentOfOneStaminaReducedCorrectly()
        {
            Player player = new Player();
            player.stamina = 100;

            int timeSpent = 1;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 75;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }
    }
}
