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

        [Test]
        public void GivenPlayerStaminaSetStaminaAndGetStaminaWorkProperly()
        {
            int stamina = 150;
            player.setStamina(stamina);
            int actual = player.getStamina();
            Assert.AreEqual(stamina, actual);
        }

        [Test]
        public void GivenPlayerHealthSetAndGetPlayerHealthWorkProperly()
        {
            int health = 150;
            player.setHealth(health);
            int actual = player.getHealth();
            Assert.AreEqual(health, actual);
        }

        [Test]
        public void GivenPlayerAttackSetAndGetPlayerAttackWorkProperly()
        {
            int attack = 10;
            player.setAttack(attack);
            int actual = player.getAttack();
            Assert.AreEqual(attack, actual);
        }

        [Test]
        public void GivenPlayerDefenseSetAndGetPlayerDefenseWorkProperly()
        {
            int defense = 10;
            player.setDefense(defense);
            int actual = player.getDefense();
            Assert.AreEqual(defense, actual);
        }

    }
}