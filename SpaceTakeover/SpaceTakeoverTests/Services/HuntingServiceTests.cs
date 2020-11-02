using NUnit.Framework;
using SpaceTakeover.DAL.Models;
using SpaceTakeover.Data.Services;
using SpaceTakover.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Tests.Services
{
    class HuntingServiceTests
    {
        IHuntingService sut;
        Player player;

        [SetUp]
        public void SetUp()
        {
            sut = new HuntingService();
            player = new Player();
        }

        [Test]
        public void WhenGivenNumberBetweenOneAndForty_GetAnimalToHuntReturnsCorrectAnimal()
        {
            const int minNumber = 1;
            const int maxNumber = 40;

            var minActual = sut.GetAnimalToHunt(minNumber);
            var maxActual = sut.GetAnimalToHunt(maxNumber);

            var expected = new Animal()
            {
                Name = "Pig",
                // ItemsDropped = { "Pork", Pork };
            }
            //Assert.AreEqual();
        }
    }
}
