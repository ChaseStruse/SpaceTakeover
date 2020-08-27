using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Models
{
    public class Ship
    {
        private string name;
        private int health;
        private int attack;
        private int defense;
        private int cargoSize;
        private int maxCargoSize;

        public Ship()
        {
            name = "Ship Name";
            health = 100;
            attack = 10;
            defense = 10;
            cargoSize = 0;
            maxCargoSize = 100;
        }
        public Ship(string name, int health, int attack, int defense, int cargoSize, int maxCargoSize)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.defense = defense;
            this.cargoSize = cargoSize;
            this.maxCargoSize = maxCargoSize;
        }

        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }

        public void setHealth(int _health)
        {
            health = _health;
        }
        public int getHealth()
        {
            return health;
        }

        public void setAttack(int _attack)
        {
            attack = _attack;
        }
        public int getAttack()
        {
            return attack;
        }

        public void setDefense(int _defense)
        {
            defense = _defense;
        }
        public int getDefense()
        {
            return defense;
        }

        public void setCargoSize(int _cargoSize)
        {
            cargoSize = _cargoSize;
        }
        public int getCargoSize()
        {
            return cargoSize;
        }

        public void setMaxCargoSize(int _maxCargoSize)
        {
            maxCargoSize = _maxCargoSize;
        }
        public int getMaxCargoSize()
        {
            return maxCargoSize;
        }

    }
}
