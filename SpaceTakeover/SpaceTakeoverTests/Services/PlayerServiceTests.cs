using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Data.Services;
using SpaceTakeover.Models;

namespace SpaceTakeover.Tests.Services
{
    class PlayerServiceTests
    {
        PlayerService sut;
        Player player;
        [SetUp]
        public void SetUp()
        {
            sut = new PlayerService();
            player = new Player();
        }

        [Test]
        public void GivenTimeSpentOfZeroStaminaIsNotReducedAndSuccessIsFalse()
        {

            player.stamina = 100;
            player.timeToSpendOnTask = 0;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 100;

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }

        [Test]
        public void GivenTimeSpentOfOneStaminaReducedCorrectly()
        {
            player.stamina = 100;

            player.timeToSpendOnTask = 1;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 75;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfTwoStaminaIsReducedAndSuccessIsTrue()
        {
            player.stamina = 100;
            player.timeToSpendOnTask = 2;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 75;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfThreeStaminaIsReducedAndSuccessIsTrue()
        {
            player.stamina = 100;
            player.timeToSpendOnTask = 3;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 50;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfFourStaminaIsReducedAndSuccessIsTrue()
        {
            player.stamina = 100;
            player.timeToSpendOnTask = 4;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 50;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfFiveStaminaIsReducedAndSuccessIsTrue()
        {
            player.stamina = 100;
            player.timeToSpendOnTask = 5;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 50;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfSixStaminaIsReducedAndSuccessIsTrue()
        {
            player.stamina = 100;
            player.timeToSpendOnTask = 6;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 25;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfSevenStaminaIsReducedAndSuccessIsTrue()
        {
            player.stamina = 100;
            player.timeToSpendOnTask = 7;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 25;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfEightStaminaIsReducedAndSuccessIsTrue()
        {
            player.stamina = 100;
            player.timeToSpendOnTask = 8;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 0;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenPlayerStaminaLessThanRequiredStaminaSuccessIsFalseAndQuantityIsUnchanged()
        {
            player.stamina = 10;
            player.timeToSpendOnTask = 8;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 10;

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }

        [Test]
        public void GivenTimeSpentIsGreaterThanEightStaminaIsUnchangedAndSuccessIsFalse()
        {

            player.stamina = 10;
            player.timeToSpendOnTask = 10;

            bool success = sut.ReduceStamina(player);
            int actual = player.stamina;
            int expected = 10;

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }
    }
}
