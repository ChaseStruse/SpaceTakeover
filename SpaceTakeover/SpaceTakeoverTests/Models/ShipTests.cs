using NUnit.Framework;
using SpaceTakeover.Data.Models;
using SpaceTakeover.Models;

namespace SpaceTakeoverTests
{
    public class ShipTests
    {
        private Ship ship;

        [SetUp]
        public void Setup() => this.ship = new Ship();

        [Test]
        public void GivenShipNameSetNameAndGetNameWorkProperly()
        {
            string name = "Dope Ship Name";
            ship.setName(name);
            string actual = ship.getName();
            Assert.AreEqual(name, actual);
        }

        [Test]
        public void GivenShipHealthSetAndGetWorkProperly()
        {
            int health = 150;
            ship.setHealth(health);
            int actual = ship.getHealth();
            Assert.AreEqual(health, actual);
        }

        [Test]
        public void GivenShipAttackGetAndSetWorkProperly()
        {
            int attack = 15;
            ship.setAttack(attack);
            int actual = ship.getAttack();
            Assert.AreEqual(attack, actual);
        }

        [Test]
        public void GivenShipDefenseGetAndSetWorkProperly()
        {
            int defense = 20;
            ship.setDefense(defense);
            int actual = ship.getDefense();
            Assert.AreEqual(defense, actual);
        }

        [Test]
        public void GivenShipCargoSizeGetAndSetWorkProperly()
        {
            int cargoSize = 100;
            ship.setCargoSize(cargoSize);
            int actual = ship.getCargoSize();
            Assert.AreEqual(cargoSize, actual);
        }

        [Test]
        public void GivenShipMaxCargoSizeGetAndSetWorkProperly()
        {
            int maxCargoSize = 1000;
            ship.setMaxCargoSize(maxCargoSize);
            int actual = ship.getMaxCargoSize();
            Assert.AreEqual(maxCargoSize, actual);
        }
    }
}
