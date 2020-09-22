using SpaceTakeover.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Models
{
    public class Player
    {
        public string name { get; set; }
        public int stamina { get; set; }
        public int health { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int mining { get; set; }
        public int timeToSpendOnTask { get; set; }
        public Inventory inventory { get; set; }
        

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
    }
}
