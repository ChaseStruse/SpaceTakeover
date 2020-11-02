using NUnit.Framework;
using SpaceTakeover.DAL.Models;
using SpaceTakeover.Data.Services;

namespace SpaceTakeover.Tests.Services
{
    class PlayerServiceTests
    {
        IPlayerService sut;
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

            player.Stamina = 100;
            player.TimeToSpendOnTask = 0;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 100;

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
            Assert.AreEqual(0, player.TimeToSpendOnTask);
        }

        [Test]
        public void GivenTimeSpentOfOneStaminaReducedCorrectly()
        {
            player.Stamina = 100;

            player.TimeToSpendOnTask = 1;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 75;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfTwoStaminaIsReducedAndSuccessIsTrue()
        {
            player.Stamina = 100;
            player.TimeToSpendOnTask = 2;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 75;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfThreeStaminaIsReducedAndSuccessIsTrue()
        {
            player.Stamina = 100;
            player.TimeToSpendOnTask = 3;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 50;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfFourStaminaIsReducedAndSuccessIsTrue()
        {
            player.Stamina = 100;
            player.TimeToSpendOnTask = 4;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 50;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfFiveStaminaIsReducedAndSuccessIsTrue()
        {
            player.Stamina = 100;
            player.TimeToSpendOnTask = 5;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 50;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfSixStaminaIsReducedAndSuccessIsTrue()
        {
            player.Stamina = 100;
            player.TimeToSpendOnTask = 6;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 25;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfSevenStaminaIsReducedAndSuccessIsTrue()
        {
            player.Stamina = 100;
            player.TimeToSpendOnTask = 7;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 25;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenTimeSpentOfEightStaminaIsReducedAndSuccessIsTrue()
        {
            player.Stamina = 100;
            player.TimeToSpendOnTask = 8;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 0;

            Assert.AreEqual(expected, actual);
            Assert.IsTrue(success);
        }

        [Test]
        public void GivenPlayerStaminaLessThanRequiredStaminaSuccessIsFalseAndQuantityIsUnchanged()
        {
            player.Stamina = 10;
            player.TimeToSpendOnTask = 8;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 10;

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }

        [Test]
        public void GivenTimeSpentIsGreaterThanEightStaminaIsUnchangedAndSuccessIsFalse()
        {

            player.Stamina = 10;
            player.TimeToSpendOnTask = 10;

            bool success = sut.ReduceStamina(player);
            int actual = player.Stamina;
            int expected = 10;

            Assert.AreEqual(expected, actual);
            Assert.IsFalse(success);
        }
    }
}
