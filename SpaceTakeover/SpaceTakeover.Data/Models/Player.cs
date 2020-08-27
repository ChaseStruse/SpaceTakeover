using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Models
{
    public class Player
    {
        protected string name;
        protected int stamina;
        protected int health;

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
    }
}
