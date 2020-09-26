using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceTakeover.Data.Models
{
    public class Resource
    {
        public string name { get; set; }
        public decimal value { get; set; }
        public int strength { get; set; }
        public int quantityPerHour { get; set; }
        public int quantityMined { get; set; }
        public int quantityInInventory { get; set; }

        public Resource()
        {
            this.name = "Test";
            this.value = 1.0m;
            this.strength = 100;
            this.quantityPerHour = 0;
            this.quantityMined = 0;
            quantityInInventory = 0;
        }
        public Resource(string name, decimal value, int strength, int quantityPerHour, int quantityMined)
        {
            this.name = name;
            this.value = value;
            this.strength = strength;
            this.quantityPerHour = quantityPerHour;
            this.quantityMined = quantityMined;
            quantityInInventory = 0;
        }
    }
}
