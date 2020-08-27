using SpaceTakeover.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Models
{
    public class Player
    {
        private string name;
        private int stamina;
        private int health;
        private int attack;
        private int defense;
        private int mining;
        private Inventory inventory;

        public Player()
        {
            name = "test";
            stamina = 100;
            health = 100;
            attack = 10;
            defense = 10;
            mining = 10;
            inventory = new Inventory();
        }

        public Player(string _name, int _stamina, int _health, int _attack, int _defense, int _mining)
        {
            name = _name;
            stamina = _stamina;
            health = _health;
            attack = _attack;
            defense = _defense;
            mining = _mining;
        }

        public void setName(string _name)
        {
            name = _name;
        }
        public string getName()
        {
            return name;
        }

        public void setStamina(int _stamina)
        {
            stamina = _stamina;
        }

        public int getStamina()
        {
            return stamina;
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

        public void setMining(int _mining)
        {
            mining = _mining;
        }
        public int getMining()
        {
            return mining;
        }

        public Inventory getInventory()
        {
            return inventory;
        }
    }
}
