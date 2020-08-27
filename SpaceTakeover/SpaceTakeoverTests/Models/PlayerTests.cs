using NUnit.Framework;
using SpaceTakeover.Models;

namespace SpaceTakeoverTests
{
    public class Tests
    {
        private Player player;

        [SetUp]
        public void Setup()
        {
            this.player = new Player();
        }

        [Test]
        public void GivenPlayerNameSetNameAndGetNameWorkProperly()
        {
            string name = "Player Name";
            player.setName(name);
            string actual = player.getName();
            Assert.AreEqual(name, actual);
        }
    }
}