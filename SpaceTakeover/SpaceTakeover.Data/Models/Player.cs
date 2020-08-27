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

        public Player()
        {
            name = "test";
            stamina = 100;
            health = 100;
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
    }
}
