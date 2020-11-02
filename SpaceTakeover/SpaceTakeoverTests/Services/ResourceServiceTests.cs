using NUnit.Framework;
using SpaceTakeover.DAL.Models;
using SpaceTakeover.Data.Services;

namespace SpaceTakeover.Tests.Services
{
    class ResourceServiceTests
    {
        private IResourceService sut;
        private Resource resource;
        private Player player;
        private Inventory inventory;

        [SetUp]
        public void Setup()
        {
            sut = new ResourceService();
            player = new Player();
            inventory = player.Inventory;
            resource = new Resource();
        }

        [Test]
        public void WhenGivenValidPlayerAndNumberMine_MineReturnsCorrectResource()
        {
            player.TimeToSpendOnTask = 1;
            var notSoRandomNumber = 1;
            var actual = sut.Mine(player, notSoRandomNumber);

            var expected = new Resource()
            {
                Name = "Coal",
                QuantityPerHour = 50,
                Strength = 5
            };

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.QuantityPerHour, actual.QuantityPerHour);
            Assert.AreEqual(expected.Strength, actual.Strength);
            Assert.IsTrue(actual.QuantityMined != 0);
        }

        [Test]
        public void WhenGivenNumberBetweenOneAndThirtyFive_GetResourceToMineReturnsCoal()
        {
            var notSoRandomNumberMin = 1;
            var notSoRandomNumberMax = 35;
            
            var actualMin = sut.GetResourceToMine(notSoRandomNumberMin);
            var actualMax = sut.GetResourceToMine(notSoRandomNumberMax);

            var expected = new Resource()
            {
                Name = "Coal",
                QuantityPerHour = 50,
                Strength = 5
            };

            Assert.AreEqual(expected.Name, actualMin.Name);
            Assert.AreEqual(expected.QuantityPerHour, actualMin.QuantityPerHour);
            Assert.AreEqual(expected.Strength, actualMin.Strength);

            Assert.AreEqual(expected.Name, actualMax.Name);
            Assert.AreEqual(expected.QuantityPerHour, actualMax.QuantityPerHour);
            Assert.AreEqual(expected.Strength, actualMax.Strength);
        }

        [Test]
        public void WhenGivenNumberBetweenThirtySixAndSeventy_GetResourceToMineReturnsIron()
        {
            var notSoRandomNumberMin = 36;
            var notSoRandomNumberMax = 70;

            var actualMin = sut.GetResourceToMine(notSoRandomNumberMin);
            var actualMax = sut.GetResourceToMine(notSoRandomNumberMax);

            var expected = new Resource()
            {
                Name = "Iron",
                QuantityPerHour = 35,
                Strength = 7
            };

            Assert.AreEqual(expected.Name, actualMin.Name);
            Assert.AreEqual(expected.QuantityPerHour, actualMin.QuantityPerHour);
            Assert.AreEqual(expected.Strength, actualMin.Strength);

            Assert.AreEqual(expected.Name, actualMax.Name);
            Assert.AreEqual(expected.QuantityPerHour, actualMax.QuantityPerHour);
            Assert.AreEqual(expected.Strength, actualMax.Strength);
        }

        [Test]
        public void WhenGivenNumberBetweenSeventyOneAndNinety_GetResourceToMineReturnsGold()
        {
            var notSoRandomNumberMin = 71;
            var notSoRandomNumberMax = 90;

            var actualMin = sut.GetResourceToMine(notSoRandomNumberMin);
            var actualMax = sut.GetResourceToMine(notSoRandomNumberMax);

            var expected = new Resource()
            {
                Name = "Gold",
                QuantityPerHour = 20,
                Strength = 10
            };

            Assert.AreEqual(expected.Name, actualMin.Name);
            Assert.AreEqual(expected.QuantityPerHour, actualMin.QuantityPerHour);
            Assert.AreEqual(expected.Strength, actualMin.Strength);

            Assert.AreEqual(expected.Name, actualMax.Name);
            Assert.AreEqual(expected.QuantityPerHour, actualMax.QuantityPerHour);
            Assert.AreEqual(expected.Strength, actualMax.Strength);
        }

        [Test]
        public void WhenGivenNumberBetweenNinetyOneAndOneHundred_GetResourceToMineReturnsGold()
        {
            var notSoRandomNumberMin = 91;
            var notSoRandomNumberMax = 100;

            var actualMin = sut.GetResourceToMine(notSoRandomNumberMin);
            var actualMax = sut.GetResourceToMine(notSoRandomNumberMax);

            var expected = new Resource()
            {
                Name = "Diamond",
                QuantityPerHour = 5,
                Strength = 12
            };

            Assert.AreEqual(expected.Name, actualMin.Name);
            Assert.AreEqual(expected.QuantityPerHour, actualMin.QuantityPerHour);
            Assert.AreEqual(expected.Strength, actualMin.Strength);

            Assert.AreEqual(expected.Name, actualMax.Name);
            Assert.AreEqual(expected.QuantityPerHour, actualMax.QuantityPerHour);
            Assert.AreEqual(expected.Strength, actualMax.Strength);
        }

    }
}
