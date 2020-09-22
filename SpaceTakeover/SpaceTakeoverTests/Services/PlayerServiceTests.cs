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

        [Test]
        public void GivenTimeSpentOfTwoStaminaIsReducedAndSuccessIsTrue()
        {
            Player player = new Player();
            player.stamina = 100;

            int timeSpent = 2;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 75;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfThreeStaminaIsReducedAndSuccessIsTrue()
        {
            Player player = new Player();
            player.stamina = 100;

            int timeSpent = 3;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 50;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfFourStaminaIsReducedAndSuccessIsTrue()
        {
            Player player = new Player();
            player.stamina = 100;

            int timeSpent = 4;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 50;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfFiveStaminaIsReducedAndSuccessIsTrue()
        {
            Player player = new Player();
            player.stamina = 100;

            int timeSpent = 5;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 50;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfSixStaminaIsReducedAndSuccessIsTrue()
        {
            Player player = new Player();
            player.stamina = 100;

            int timeSpent = 6;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 25;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfSevenStaminaIsReducedAndSuccessIsTrue()
        {
            Player player = new Player();
            player.stamina = 100;

            int timeSpent = 7;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 25;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfEightStaminaIsReducedAndSuccessIsTrue()
        {
            Player player = new Player();
            player.stamina = 100;

            int timeSpent = 8;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 0;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenPlayerStaminaLessThanRequiredStaminaSuccessIsFalseAndQuantityIsUnchanged()
        {
            Player player = new Player();
            player.stamina = 10;

            int timeSpent = 8;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 10;

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }

        [Test]
        public void GivenTimeSpentIsGreaterThanEightStaminaIsUnchangedAndSuccessIsFalse()
        {
            Player player = new Player();
            player.stamina = 10;

            int timeSpent = 10;

            bool success = sut.ReduceStamina(player, timeSpent);
            int actual = player.stamina;
            int expected = 10;

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }
    }
}
