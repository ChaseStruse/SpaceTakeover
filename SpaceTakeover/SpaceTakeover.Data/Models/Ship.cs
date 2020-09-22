using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Models
{
    public class Ship
    {
        public string name { get; set; }
        public int health { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int cargoSize { get; set; }
        public int maxCargoSize { get; set; }

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
    }
}
